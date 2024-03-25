using MediatR;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;

namespace QuestionBank.Application.Commands.Users
{
    public class ResetPassword : IRequest<OperationResult<IdentityUser>>
    {
        public string UserName { get; set; }
        public string NewPassword { get; set; }
    }
    internal class ResetPasswordCommandHandler : IRequestHandler<ResetPassword, OperationResult<IdentityUser>>
    {
        
        private readonly IRepositoryBase<IdentityUser> _identityUser;
        private readonly IPassword _passwordService;
        public ResetPasswordCommandHandler(IRepositoryBase<IdentityUser> identityUser, IPassword password)
        {
            _identityUser = identityUser;
            _passwordService = password;
        }
        public async Task<OperationResult<IdentityUser>> Handle(ResetPassword request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<IdentityUser>();

            var userAccount = await _identityUser.FirstOrDefaultAsync(x => x.Username == request.UserName);
            if (userAccount is null)
            {
                result.AddError(ErrorCode.IdentityUserDoesNotExist, "Account Does not Exist");
                return result;
            }
            userAccount.UpdatePassword(await _passwordService.HashPassword(request.NewPassword));
            _identityUser.Update(userAccount);

            result.Payload = userAccount;
            result.Message = "Operation success";
            return result;
        }
    }
}
