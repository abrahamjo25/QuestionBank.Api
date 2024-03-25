using QuestionBank.Domain.Models.Shared;
using QuestionBank.Domain.Models.User;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;
using Microsoft.EntityFrameworkCore;

namespace QuestionBank.Application.Queries.ClientClaims;
public class GetClientClaimByClientId : IRequest<OperationResult<IEnumerable<ClientClaim>>>
{
    public long CientId { get; set; }
}
internal class GGetClientClaimByClientIdQueryHandler : IRequestHandler<GetClientClaimByClientId, OperationResult<IEnumerable<ClientClaim>>>
{
    private readonly IRepositoryBase<ClientClaim> _clientClaims;
    public GGetClientClaimByClientIdQueryHandler(IRepositoryBase<ClientClaim> clientClaims)
    {
        _clientClaims = clientClaims;
    }
    public async Task<OperationResult<IEnumerable<ClientClaim>>> Handle(GetClientClaimByClientId request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<IEnumerable<ClientClaim>>();
        try
        {
            var clientClaim = await _clientClaims.Where(x => x.RecordStatus != RecordStatus.Deleted && x.ClientId==request.CientId).ToListAsync();
            if (clientClaim is null)
            {
                result.AddError(ErrorCode.NotFound, "Client claim is not found!");
                return result;
            }
            result.Payload = clientClaim;
            return result;

        }
        catch (Exception ex)
        {
            result.AddError(ErrorCode.ServerError, ex.Message);
        }
        return result;
    }

}


