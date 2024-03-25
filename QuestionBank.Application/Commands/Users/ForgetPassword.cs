using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Application.Helpers.Dtos;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.User;

namespace QuestionBank.Application.Commands.Users
{
    public class ForgotPassword : IRequest<OperationResult<IdentityUser>>
    {
        public string UserName { get; set; }
    }
    internal class ForgotPasswordCommandHandler : IRequestHandler<ForgotPassword, OperationResult<IdentityUser>>
    {
        private readonly IMapper _mapper;
        private readonly IRepositoryBase<Role> _role;
        private readonly IEmailSender _emailSenderService;
        private readonly ITokenhandler _tokenHandler;
        private readonly IRepositoryBase<IdentityUser> _identityuser;
        private readonly IRepositoryBase<ClientClaim> _clientClaim;
        public ForgotPasswordCommandHandler(IRepositoryBase<IdentityUser> identityuser, IRepositoryBase<Role> role, IRepositoryBase<ClientClaim> clientClaim, ITokenhandler tokenHandler,
            IEmailSender emailSenderService, IMapper mapper)
        {
            _role = role;   
            _mapper = mapper;
            _clientClaim = clientClaim;
            _identityuser = identityuser;
            _emailSenderService = emailSenderService;
            _tokenHandler = tokenHandler;
        }
        public async Task<OperationResult<IdentityUser>> Handle(ForgotPassword request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<IdentityUser>();
            var userAccount = await _identityuser.FirstOrDefaultAsync(x => x.Username == request.UserName, "IdentityUserRoles");
            if (userAccount is null)
            {
                result.AddError(ErrorCode.IdentityUserDoesNotExist, "Account Does not Exist");
                return result;
            }

            var Roles = await GetRole(userAccount);
            string token =await _tokenHandler.GetJwtString(30/* five minutes to expire*/, await _tokenHandler.GetClaimFromRole(Roles));
            if (String.IsNullOrEmpty(token))
            {
                result.AddError(ErrorCode.IncorrectPassword, "Invalide Token.");
                return result;
            }

            string CallbakUrl = $"{BaseUrl.PortalBaseUrl()}" + "#/reset-password?activation_token=" + token;

          
            string message = "<p>Please reset your password by clicking <a href='" + CallbakUrl + "'>here</a> here</p>";


            await _emailSenderService.SendEmailAsync(message, "Forgot Password", new string[] { userAccount.Email }, null, null);

            result.Payload = userAccount;
            result.Message = "Operation success";

            return result;
        }

        private async Task<List<RoleDto>> GetRole(IdentityUser user)
        {
            var result = new List<RoleDto>();
            if (user.IdentityUserRoles.Any())
            {
                var roles = await _role.
                    Where(x => user.IdentityUserRoles.Select(x => x.RoleId).ToList().Contains(x.Id))
                    .Include(x => x.RoleClaims)
                    .ToListAsync();
                foreach (var role in roles)
                {
                    var roleDto = new RoleDto();
                    var claimIds = role.RoleClaims.Select(x => x.ClientClaimId).ToList();
                    var claims = _clientClaim.Where(x => claimIds.Contains(x.Id)).ToList();
                    roleDto.Claims = _mapper.Map<List<ClientClaimDto>>(claims);
                    result.Add(roleDto);
                }
            }
            return result;
        }


    }
}
