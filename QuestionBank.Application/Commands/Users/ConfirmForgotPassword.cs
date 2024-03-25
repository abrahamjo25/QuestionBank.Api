using QuestionBank.Application.Helpers.Common;
using MediatR;
using QuestionBank.Domain.Models;
namespace QuestionBank.Application.Commands.Users
{
    public class ConfirmForgotPassword : IRequest<OperationResult<IdentityUser>>
    {
        public string UserName { get; set; }
        public string Token { get; set; }
        public string Password { get; set; }
    }
    internal class ConfirmForgotPasswordCommandHandler : IRequestHandler<ConfirmForgotPassword, OperationResult<IdentityUser>>
    {
        private readonly IPassword _passwordService;
        private readonly ITokenhandler _tokenHandler;
        private readonly IRepositoryBase<IdentityUser> _identityUser;
        public ConfirmForgotPasswordCommandHandler(IRepositoryBase<IdentityUser> identityUser, IPassword password, ITokenhandler tokenHandler)
        {
            _identityUser = identityUser;
            _passwordService = password;
            _tokenHandler= tokenHandler;
        }
        public async Task<OperationResult<IdentityUser>> Handle(ConfirmForgotPassword request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<IdentityUser>();
            var userAccount = await _identityUser.FirstOrDefaultAsync(x => x.Username == request.UserName);
            if (userAccount is null)
            {
                result.AddError(ErrorCode.IdentityUserDoesNotExist, "Account Does not Exist");
                return result;
            }

            if (! await _tokenHandler.ValidateToken(request.Token))
            {
                result.AddError(ErrorCode.IncorrectPassword, "Invalide Token.");
                return result;
            }
            userAccount.UpdatePassword(await _passwordService.HashPassword(request.Password));
            _identityUser.Update(userAccount);
            
            result.Payload = userAccount;
            result.Message = "Operation success";

            return result;
        }
    }
}

