using QuestionBank.Application.Helpers.Common;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Domain.Models;
namespace QuestionBank.Application.Commands.Users
{
    public class ChangePassword : IRequest<OperationResult<IdentityUser>>
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
    internal class ChangePasswordCommandHandler : IRequestHandler<ChangePassword, OperationResult<IdentityUser>>
    {
        private readonly IRepositoryBase<IdentityUser> _identityUser;
        private readonly IPassword _passwordService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        private ISession _session => _httpContextAccessor.HttpContext.Session;

        public ChangePasswordCommandHandler(IRepositoryBase<IdentityUser> identityUser, IPassword password, IHttpContextAccessor httpContextAccessor)
        {
            _identityUser = identityUser;
            _passwordService = password;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<IdentityUser>> Handle(ChangePassword request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<IdentityUser>();
            var userAccount = await _identityUser.FirstOrDefaultAsync(x => x.Username == _session.GetString("user"));
            if (userAccount is null)
            {
                result.AddError(ErrorCode.IdentityUserDoesNotExist, "Account Does not Exist");
                return result;
            }

            if (! await _passwordService.ValidatePassword(userAccount.Password, request.OldPassword))
            {
                result.AddError(ErrorCode.IncorrectPassword, "Invalide password.");
                return result;
            }

            userAccount.UpdatePassword(await _passwordService.HashPassword(request.NewPassword));
            userAccount.UpdateAudit(_session.GetString("user"));
            _identityUser.Update(userAccount);

            result.Payload = userAccount;
            result.Message = "Operation success";
            return result;
        }
    }
}

