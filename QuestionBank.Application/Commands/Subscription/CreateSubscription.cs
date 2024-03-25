using QuestionBank.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
namespace QuestionBank.Application.Commands;
public class CreateSubscription : IRequest<OperationResult<Subscription>>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Code { get; set; }
}

internal class CreateSubscriptionCommandHandler : IRequestHandler<CreateSubscription, OperationResult<Subscription>>
{
    private readonly IRepositoryBase<Subscription> _subscription;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private ISession _session => _httpContextAccessor.HttpContext.Session;
    public CreateSubscriptionCommandHandler(IRepositoryBase<Subscription> subscription, IHttpContextAccessor httpContextAccessor)
    {
        _subscription = subscription;
        _httpContextAccessor = httpContextAccessor;
    }
    public async Task<OperationResult<Subscription>> Handle(CreateSubscription request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<Subscription>();
        var existingSubscription = await _subscription.FirstOrDefaultAsync(s => s.Name == request.Name && s.RecordStatus != RecordStatus.Deleted);
        if (existingSubscription is not null)
        {
            result.AddError(ErrorCode.RecordExist, "Subscription already exist.");
            return result;
        }
        var subscription = Subscription.Create(request.Name, request.Description, request.Code);
        _subscription.Add(subscription);
        result.Payload = subscription;
        result.Message = "Operation success";
        return result;
    }
}
