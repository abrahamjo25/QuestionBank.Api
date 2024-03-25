using QuestionBank.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
namespace QuestionBank.Application.Commands.Users
{
    public class ActivateUser : IRequest<OperationResult<IdentityUser>>
    {
        public UserStatusAction StatusAction { get; set; }
        public long UserId { get; set; }
    }
    public class UserActivationCommandHandler : IRequestHandler<ActivateUser, OperationResult<IdentityUser>>
    {

        private readonly IRepositoryBase<IdentityUser> _identityUser;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public UserActivationCommandHandler(IRepositoryBase<IdentityUser> identityUser, IHttpContextAccessor httpContextAccessor)
        {
            _identityUser = identityUser;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<IdentityUser>> Handle(ActivateUser request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<IdentityUser>();
            var userAccount = await _identityUser.FindAsync(request.UserId);
            if (userAccount is null)
            {
                result.AddError(ErrorCode.IdentityUserDoesNotExist, "Account Does not Exist");
                return result;
            }

            userAccount.ActivateDeactivate(request.StatusAction);
            userAccount.UpdateAudit(_session.GetString("user"));

            _identityUser.Update(userAccount);

            result.Payload = userAccount;
            result.Message = "Operation success";
            return result;
        }
    }
}

