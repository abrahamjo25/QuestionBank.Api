using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;

namespace QuestionBank.Application.Commands.Users;
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
        var userSubscription = await _userSubscription.FindAsync(request.Id);
        if (userSubscription is null)
        {
            result.AddError(ErrorCode.IdentityUserDoesNotExist, "user subscription Does not Exist");
            return result;
        }
        if (userSubscription.IsReadOnly)
        {
            result.AddError(ErrorCode.IdentityUserDoesNotExist, "Cannot Delete System Account");
            return result;
        }
        _userSubscription.Remove(userSubscription);
        result.Message = "Oparation success";
        result.Payload = true;
        return result;
    }
}


