using QuestionBank.Domain.Models.Shared;
using QuestionBank.Domain.Models.User;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;
using Microsoft.EntityFrameworkCore;

namespace QuestionBank.Application.Queries.ClientClaims
{
    public class GetClientClaimById : IRequest<OperationResult<ClientClaim>>
    {
        public long Id { get; set; }
    }
    internal class GetClientClaimByIdQueryHandler : IRequestHandler<GetClientClaimById, OperationResult<ClientClaim>>
    {
     
        private readonly IRepositoryBase<ClientClaim> _clientClaim;
        public GetClientClaimByIdQueryHandler(IRepositoryBase<ClientClaim> clientClaim)
        {
            _clientClaim = clientClaim;
        }


        public async Task<OperationResult<ClientClaim>> Handle(GetClientClaimById request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<ClientClaim>();
            try
            {
                var clinetClaim = await _clientClaim.FirstOrDefaultAsync(x => x.Id == request.Id && x.RecordStatus != RecordStatus.Deleted, "Client");
                   
                if (clinetClaim is null)
                {
                    result.AddError(ErrorCode.NotFound, "Client claim is not found!");
                    return result;
                }
                result.Payload = clinetClaim;
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

