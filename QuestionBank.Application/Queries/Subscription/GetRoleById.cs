using QuestionBank.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;
using Microsoft.EntityFrameworkCore;
namespace QuestionBank.Application.Queries.Roles;
public class GetSubscription : IRequest<OperationResult<Subscription>>
{
    public long Id { get; set; }
}
internal class GetSubscriptionHandler : IRequestHandler<GetSubscription, OperationResult<Subscription>>
{
    private readonly IRepositoryBase<Subscription> _subscription;
    public GetSubscriptionHandler(IRepositoryBase<Subscription> subscription)
    {
        _subscription = subscription;
    }
    public async Task<OperationResult<Subscription>> Handle(GetSubscription request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<Subscription>();
        try
        {

            var subscription = await _subscription.FirstOrDefaultAsync(x => x.Id == request.Id && x.RecordStatus != RecordStatus.Deleted, "Organizatoins");
            if (subscription is null)
            {
                result.AddError(ErrorCode.NotFound, "Subscription is not found!");
                return result;
            }
            result.Payload = subscription;
            return result;

        }
        catch (Exception ex)
        {
            result.AddError(ErrorCode.ServerError, ex.Message);
        }
        return result;
    }
}
