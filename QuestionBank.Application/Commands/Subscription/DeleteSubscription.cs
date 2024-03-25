namespace QuestionBank.Application;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
public class DeleteSubscription  : IRequest<OperationResult<bool>>
{
    public long Id { get; set; }
}
internal class DeleteSubscriptionHandler : IRequestHandler<DeleteSubscription, OperationResult<bool>>
{
    private readonly IRepositoryBase<Subscription> _subscription;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private ISession _session => _httpContextAccessor.HttpContext.Session;
    public DeleteSubscriptionHandler(IRepositoryBase<Subscription> subscription, IHttpContextAccessor httpContextAccessor)
    {
        _subscription = subscription;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<OperationResult<bool>> Handle(DeleteSubscription request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<bool>();
        var subscription = await _subscription.FirstOrDefaultAsync(x => x.Id == request.Id);
        if (subscription is null)
        {
            result.AddError(ErrorCode.NotFound, "Subscription not found");
            return result;
        }
        if (subscription.IsReadOnly)
        {
            result.AddError(ErrorCode.ValidationError, "Cannot Delete Default  Data");
            return result;
        }
        subscription.Delete();
        _subscription.Update(subscription);

        result.Message = "Operation success";
        return result;
    }
}
