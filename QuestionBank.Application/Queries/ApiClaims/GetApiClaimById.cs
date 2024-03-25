using MediatR;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.Clients;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Queries.ApiClaims
{
    public class GetApiClaimById : IRequest<OperationResult<ApiClaim>>
    {
        public long Id { get; set; }
    }
    internal class GetbyIdHandler : IRequestHandler<GetApiClaimById, OperationResult<ApiClaim>>
    {
        private readonly IRepositoryBase<ApiClaim> _apiClaim;
        public GetbyIdHandler(IRepositoryBase<ApiClaim> apiClaim) => _apiClaim = apiClaim;
        public async Task<OperationResult<ApiClaim>> Handle(GetApiClaimById request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<ApiClaim>();
            try
            {
                var apiClaim = await _apiClaim.FirstOrDefaultAsync(x => x.Id == request.Id && x.RecordStatus!=RecordStatus.Deleted, "Service");
               
                if (apiClaim is null)
                {
                    result.AddError(ErrorCode.NotFound, "Unable to find ApiClaim");
                    return result;
                }

                if (apiClaim.RecordStatus == RecordStatus.InActive)
                {
                    result.AddError(ErrorCode.NotFound, "ApiClaim is Inactive");
                    return result;
                }
                result.Payload = apiClaim;
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
