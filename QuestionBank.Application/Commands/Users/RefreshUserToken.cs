using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using MediatR;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Application.Helpers.Dtos;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Commands.Users
{
    public class RefreshUser : IRequest<OperationResult<UserLoginDto>>
    {
        public string RefreshToken { get; set; }
    }
    internal class RefreshUserTokenHandler : IRequestHandler<RefreshUser, OperationResult<UserLoginDto>>
    {
       
        private readonly IRepositoryBase<IdentityUser> _identityUser;
        private readonly IPassword _passwordService;
        private readonly ITokenhandler _tokenService;
        public RefreshUserTokenHandler(IRepositoryBase<IdentityUser> identityUser, IPassword passwordService, ITokenhandler tokenService)
        {
            _identityUser = identityUser;
            _passwordService = passwordService;
            _tokenService = tokenService;
        }
        public async Task<OperationResult<UserLoginDto>> Handle(RefreshUser request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<UserLoginDto>();
            try
            {
                var user = await _identityUser.FirstOrDefaultAsync(x => x.RefreshToken == request.RefreshToken, "IdentityUserRoles", "IdentityUserRoles.Role", "IdentityUserRoles.Role.RoleClaims", "IdentityUserRoles.Role.RoleClaims.ClientClaim");
                if (user is null)
                {
                    result.AddError(ErrorCode.IdentityUserDoesNotExist, "User doesn't exist .");
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
                var identityUser = new UserLoginDto(user.Username, user.Email, user.FirstName, user.LastName , user.IsCompany, user.CompanyCode);
                identityUser.Id = user.Id;
                identityUser.Roles = await _getRole(user);
                identityUser.IdToken = await GetJwtString(user.IdTokenLifetime, _getClaim(identityUser));
                identityUser.RefreshToken = await _setRefreshToken(user);
                result.Payload = identityUser;
                return result;

            }
            catch (Exception ex)
            {
                result.AddError(ErrorCode.ServerError, ex.Message);
                return result;
            }
        }
        private static async Task<List<RoleDto>> _getRole(IdentityUser user)
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
        private static List<Claim> _getClaim(UserLoginDto user)
        {
            var result = new List<Claim>();
            result.Add(new Claim("userName", user.Username));
            foreach (var role in user.Roles)
            {
                foreach (var clientClaim in role.Claims)
                {
                    Claim claim = new Claim(clientClaim.Id.ToString(), String.Format("{0}", clientClaim.Claim));
                    result.Add(claim);
                }
            }
            return result;
        }
        public async Task<string> GetJwtString(int tokenLife, List<Claim> claimList)
        {
            var claims = new[]
                {
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
             }
                .Union(claimList).ToList();
            var token = await _tokenService.CreateSecurityToken(claims, tokenLife);
            return await _tokenService.WriteToken(token);
        }
        private async Task<string> _setRefreshToken(IdentityUser user)
        {
            user.RefreshTokenExpireDate = DateTime.UtcNow.AddMinutes(user.IdTokenLifetime);
            user.RefreshToken = await _tokenService.GenerateRefreshToken();
            _identityUser.Update(user);
            return user.RefreshToken;
        }

    }
}
