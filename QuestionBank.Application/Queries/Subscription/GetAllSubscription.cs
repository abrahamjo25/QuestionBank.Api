using QuestionBank.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;
using Microsoft.EntityFrameworkCore;
namespace QuestionBank.Application.Queries.Roles
{
    public class GetAllSubscription : IRequest<OperationResult<List<Subscription>>>
    {
        public RecordStatus? RecordStatus { get; set; }
    }
    internal class GetAllSubscriptionHandler : IRequestHandler<GetAllSubscription, OperationResult<List<Subscription>>>
    {
        private readonly IRepositoryBase<Subscription> _subscription;
        public GetAllSubscriptionHandler(IRepositoryBase<Subscription> subscription)
        {
            _subscription = subscription;
        }
        public async Task<OperationResult<List<Subscription>>> Handle(GetAllSubscription request, CancellationToken cancellationToken)
        {

            var result = new OperationResult<List<Subscription>>();
            try
            {

                var subscriptions = request.RecordStatus switch
                {
                    RecordStatus.Active => await _subscription.Where(x => x.RecordStatus == RecordStatus.Active, "Organizatoins").ToListAsync(),
                    RecordStatus.InActive => await _subscription.Where(x => x.RecordStatus == RecordStatus.InActive, "Organizatoins").ToListAsync(),
                    _ => await _subscription.Where(x => x.RecordStatus != RecordStatus.Deleted, "Organizatoins").ToListAsync(),
                };
                
                if (subscriptions.Count == 0)
                {
                    result.AddError(ErrorCode.NotFound, "No subscription data!");
                    return result;
                }
                result.Payload = subscriptions;
                return result;

            }
            catch (Exception ex)
            {
                result.AddError(ErrorCode.ServerError, ex.Message);
            }
            return result;
        }
    }
}
