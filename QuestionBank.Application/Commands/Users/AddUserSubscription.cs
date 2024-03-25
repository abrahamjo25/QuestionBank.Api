using QuestionBank.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
namespace QuestionBank.Application.Commands.Users
{
    public class AddUserSubscription : IRequest<OperationResult<UserSubscription>>
    {
        public long UserId { get; set; }
        public long ClientId { get; set; }
        public long OrganizatoinId { get; set; }
        public bool IsDefault { get; set; }
    }

    public class AddUserSubscriptionHandler : IRequestHandler<AddUserSubscription, OperationResult<UserSubscription>>
    {
        private readonly IRepositoryBase<UserSubscription> _userSubscription;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public AddUserSubscriptionHandler(IRepositoryBase<UserSubscription> userSubscription, IHttpContextAccessor httpContextAccessor)
        {
            _userSubscription = userSubscription;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<UserSubscription>> Handle(AddUserSubscription request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<UserSubscription>();

            var existingSubscription = await _userSubscription.FirstOrDefaultAsync(s => s.UserId == request.UserId &&
            s.ClientId == request.ClientId &&
            s.OrganizatoinId == request.OrganizatoinId
            && s.RecordStatus != RecordStatus.Deleted);
            if (existingSubscription is not null)
            {
                result.AddError(ErrorCode.RecordExist, "Subscription already exist.");
                return result;
            }
            var subscription = UserSubscription.Create(request.UserId, request.ClientId, request.OrganizatoinId, request.IsDefault);
            _userSubscription.Add(subscription);
            result.Payload = subscription;
            result.Message = "Operation success";
            return result;
        }
    }
}
