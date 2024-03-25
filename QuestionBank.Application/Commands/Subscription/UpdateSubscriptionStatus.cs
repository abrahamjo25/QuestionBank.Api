using QuestionBank.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
namespace QuestionBank.Application.Commands;
public class UpdateSubscriptionStatus : IRequest<OperationResult<Subscription>>
{
    public long Id { get; set; }
    public RecordStatus Status { get; set; }
}
internal class UpdateSubscriptionStatusHandler : IRequestHandler<UpdateSubscriptionStatus, OperationResult<Subscription>>
{
    private readonly IRepositoryBase<Subscription> _subscription;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private ISession _session => _httpContextAccessor.HttpContext.Session;
    public UpdateSubscriptionStatusHandler(IRepositoryBase<Subscription> subscription, IHttpContextAccessor httpContextAccessor)
    {
        _subscription = subscription;
        _httpContextAccessor = httpContextAccessor;
    }
    public async Task<OperationResult<Subscription>> Handle(UpdateSubscriptionStatus request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<Subscription>();
        try
        {
            var subscription = await _subscription.FirstOrDefaultAsync(s => s.Id == request.Id && s.RecordStatus != RecordStatus.Deleted);
            if (subscription is null)
            {
                result.AddError(ErrorCode.NotFound, "Subscription not found!");
                return result;
            }

            subscription.UpdateRecordStatus(request.Status);
            _subscription.Update(subscription);

            result.Payload = subscription;
            result.Message = "Operation Success";

            return result;

        }
        catch (Exception ex)
        {
            result.AddError(ErrorCode.ServerError, ex.Message);
        }

        return result;
    }
}
