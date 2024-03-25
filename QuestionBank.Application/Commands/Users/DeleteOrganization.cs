using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;

namespace QuestionBank.Application.Commands;
public class DeleteUserSubscription : IRequest<OperationResult<bool>>
{
    public long Id { get; set; }
}
internal class DeleteUserSubscriptionHandler : IRequestHandler<DeleteUserSubscription, OperationResult<bool>>
{
    private readonly IRepositoryBase<UserSubscription> _userSubscription;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private ISession _session => _httpContextAccessor.HttpContext.Session;
    public DeleteUserSubscriptionHandler(IRepositoryBase<UserSubscription> userSubscription, IHttpContextAccessor httpContextAccessor)
    {
        _userSubscription = userSubscription;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<OperationResult<bool>> Handle(DeleteUserSubscription request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<bool>();
        var userSubscription = await _userSubscription.FirstOrDefaultAsync(x => x.Id == request.Id);
        if (userSubscription is null)
        {
            result.AddError(ErrorCode.NotFound, "User subscription not found");
            return result;
        }
        if (userSubscription.IsReadOnly)
        {
            result.AddError(ErrorCode.ValidationError, "Cannot Delete Default Data");
            return result;
        }
        userSubscription.Delete();
        _userSubscription.Update(userSubscription);

        result.Message = "Operation success";
        return result;
    }
}
