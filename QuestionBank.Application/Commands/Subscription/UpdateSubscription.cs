using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;
namespace QuestionBank.Application.Commands
{
    public class UpdateSubscription : IRequest<OperationResult<Subscription>>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
    internal class UpdateSubscriptionHandler : IRequestHandler<UpdateSubscription, OperationResult<Subscription>>
    {
        private readonly IRepositoryBase<Subscription> _subscription;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public UpdateSubscriptionHandler(IRepositoryBase<Subscription> subscription, IHttpContextAccessor htstpContextAccessor)
        {
            _subscription = subscription;
            _httpContextAccessor = htstpContextAccessor;
        }
        public async Task<OperationResult<Subscription>> Handle(UpdateSubscription request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Subscription>();
            var subscription = await _subscription.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (subscription == null)
            {
                result.AddError(ErrorCode.NotFound, "Subscription not found found!");
                return result;
            }
            if (_subscription.ExistWhere(s => s.Name == request.Name && s.Id != request.Id))
            {
                result.AddError(ErrorCode.RecordExist, "Subscription already sexist");
                return result;
            }
            subscription.Update(request.Name, request.Description, request.Code);
            _subscription.Update(subscription);

            result.Payload = subscription;
            result.Message = "Operation success";
            return result;

        }
    }
}
