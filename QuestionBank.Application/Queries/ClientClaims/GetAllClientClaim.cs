using MediatR;
using Microsoft.EntityFrameworkCore;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.Shared;
using QuestionBank.Domain.Models.User;

namespace QuestionBank.Application.Queries.ClientClaims
{
    public class GetAllClientClaim : IRequest<OperationResult<IEnumerable<ClientClaim>>>
    {
    }
    internal class GetAllClientClaimQueryHandler : IRequestHandler<GetAllClientClaim, OperationResult<IEnumerable<ClientClaim>>>
    {
        private readonly IRepositoryBase<ClientClaim> _clientClaims;
        public GetAllClientClaimQueryHandler(IRepositoryBase<ClientClaim> clientClaims)
        {
            _clientClaims = clientClaims;
        }
        public async Task<OperationResult<IEnumerable<ClientClaim>>> Handle(GetAllClientClaim request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<IEnumerable<ClientClaim>>();
            try
            {
                var clientClaim = await _clientClaims.Where(x => x.RecordStatus != RecordStatus.Deleted).ToListAsync();
                 
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
}
