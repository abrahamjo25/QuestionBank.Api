using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Application.Helpers.Dtos;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Commands.Users
{
    public class LoginUser : IRequest<OperationResult<UserLoginDto>>
    {
        public string Username { get; set; }
        public string Password { get; set; }
        //public bool IsCompany { get; set; }
    }
    internal class LoginUserCommandHandler : IRequestHandler<LoginUser, OperationResult<UserLoginDto>>
    {
        private readonly IMapper _mapper;
        private readonly IPassword _passwordService;
        private readonly ITokenhandler _tokenService;
        private readonly IRepositoryBase<Role> _role;
        private readonly IRepositoryBase<Client> _client;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IRepositoryBase<IdentityUser> _identityUser;
        private readonly IRepositoryBase<UserSubscription> _userSubscription;
        private ISession _session => _httpContextAccessor.HttpContext.Session;

        public LoginUserCommandHandler(IRepositoryBase<IdentityUser> identityUser, IRepositoryBase<Client> client, IRepositoryBase<Role> role, IPassword passwordService,
            ITokenhandler tokenService, IMapper mapper, IHttpContextAccessor httpContextAccessor, IRepositoryBase<UserSubscription> userSubscription)
        {
            _role = role;
            _mapper = mapper;
            _client = client;
            _identityUser = identityUser;
            _tokenService = tokenService;
            _passwordService = passwordService;
            _userSubscription = userSubscription;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<UserLoginDto>> Handle(LoginUser request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<UserLoginDto>();

            var user = await _identityUser.FirstOrDefaultAsync(x => x.Username == request.Username, "IdentityUserRoles", "IdentityUserRoles.Role",
                "IdentityUserRoles.Role.RoleClaims", "IdentityUserRoles.Role.RoleClaims.ClientClaim");
            if (user is null)
            {
                result.AddError(ErrorCode.IdentityUserDoesNotExist, "User doesn't exist.");
                return result;
            }
            if (user.IdentityUserRoles.Count == 0)
            {
                result.AddError(ErrorCode.UnAuthorized, "User doesn't have a Role");
                return result;
            }
            if (!await _passwordService.ValidatePassword(user.Password, request.Password))
            {
                result.AddError(ErrorCode.IncorrectPassword, "Invalide password.");
                return result;
            }
            if (user.IsAccountLocked)
            {
                result.AddError(ErrorCode.ServerError, "Your account is locked");
                return result;
            }
            if (user.RecordStatus != RecordStatus.Active)
            {
                result.AddError(ErrorCode.IdentityUserDoesNotExist, "User doesn't exist.");
                return result;
            }

            var identityUser = new UserLoginDto(user.Username, user.Email, user.FirstName, user.LastName, user.IsCompany, user.CompanyCode);
            identityUser.Id = user.Id;
            //identityUser.CompanyCode = user.CompanyCode;
            identityUser.Roles = await _getRole(user);


            // check if the user is in that role
            var clientId = _session.GetString("client");
            var client = await _client.FirstOrDefaultAsync(s => s.ClientId == clientId);
            if (client is null)
            {
                result.AddError(ErrorCode.NotFound, "Role doesn't exist.");
                return result;
            }
            identityUser.Organizations = await _getOrganisation(client.Id, user.Id);

            List<long> clientIds = _role.Where(r => identityUser.Roles.Select(s => s.RoleName).Contains(r.Name)).Select(s => s.ClientId).ToList();
            if (!clientIds.Contains(client.Id))
            {
                result.AddError(ErrorCode.UnAuthorized, "Your have no Access to login.");
                return result;
            }

            identityUser.IdToken = await GetJwtString(user.IdTokenLifetime, _getClaim(identityUser));
            identityUser.RefreshToken = await SetRefreshToken(user);
            result.Payload = identityUser;
            return result;
        }

        private async Task<List<RoleDto>> _getRole(IdentityUser user)
        {
            var result = new List<RoleDto>();
            if (user.IdentityUserRoles.Any())
            {
                foreach (var userRole in user.IdentityUserRoles)
                {
                    var roleDto = new RoleDto();
                    roleDto.RoleName = userRole.Role.Name;
                    foreach (var roleClaim in userRole.Role.RoleClaims)
                    {
                        roleDto.Claims.Add(new ClientClaimDto
                        {
                            Id = roleClaim.ClientClaim.Id,
                            ClientId = roleClaim.ClientClaim.ClientId,
                            Claim = roleClaim.ClientClaim.Claim
                        });

                    }
                    result.Add(roleDto);

                }
            }

            return result;
        }
        private List<Claim> _getClaim(UserLoginDto user)
        {
            var result = new List<Claim>();
            result.Add(new Claim("userName", user.Username));
            result.Add(new Claim("CompanyCode", user.CompanyCode));
            result.Add(new Claim("IsCompany", Convert.ToString(user.IsCompany)));
            foreach (var role in user.Roles)
                foreach (var clientClaim in role.Claims)
                    result.Add(new Claim(clientClaim.Id.ToString(), String.Format("{0}", clientClaim.Claim)));


            foreach (var organizaiton in user.Organizations)
                result.Add(new Claim("ORGS", organizaiton.OrganizationCode));

            return result;
        }
        private async Task<string> GetJwtString(int tokenLife, List<Claim> claimList)
        {
            var claims = new[]
                {
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
             }
                .Union(claimList).ToList();
            var token = await _tokenService.CreateSecurityToken(claims, tokenLife);
            return await _tokenService.WriteToken(token);
        }
        public async Task<string> SetRefreshToken(IdentityUser user)
        {
            user.RefreshTokenExpireDate = DateTime.UtcNow.AddMinutes(user.IdTokenLifetime);
            user.RefreshToken = await _tokenService.GenerateRefreshToken();
            _identityUser.Update(user);
            return user.RefreshToken;
        }

        private async Task<List<OrganizationDto>> _getOrganisation(long clientId, long userId)
        {
            var organizations = _userSubscription
                .Where(x => x.ClientId == clientId && x.UserId == userId && x.RecordStatus == RecordStatus.Active)
                .Include(x => x.Organizatoin)
                .Select(x => x.Organizatoin)
                .ToList();
            return _mapper.Map<List<OrganizationDto>>(organizations);  

        }
    }
}

