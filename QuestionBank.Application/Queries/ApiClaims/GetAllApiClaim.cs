using MediatR;
using Microsoft.EntityFrameworkCore;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.Clients;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Queries.ApiClaims
{
    public class GetAllApiClaim : IRequest<OperationResult<List<ApiClaim>>>
    {
        public RecordStatus? RecordStatus { get; set; }
    }
    internal class GetAllApiClaimHandler : IRequestHandler<GetAllApiClaim, OperationResult<List<ApiClaim>>>
    {
        private readonly IRepositoryBase<ApiClaim> _apiClaim;
        public GetAllApiClaimHandler(IRepositoryBase<ApiClaim> apiClaim) => _apiClaim = apiClaim;
        public async Task<OperationResult<List<ApiClaim>>> Handle(GetAllApiClaim request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<List<ApiClaim>>();
            try
            {
                var apiClaims = request.RecordStatus switch
                {
                    RecordStatus.Active => await _apiClaim.Where(s => s.RecordStatus == RecordStatus.Active, "Service").ToListAsync(),
                    RecordStatus.InActive => await _apiClaim.Where(s => s.RecordStatus == RecordStatus.InActive, "Service").ToListAsync(),
                    _ => await _apiClaim.Where(s => s.RecordStatus != RecordStatus.Deleted, "Service").ToListAsync(),
                };
                if (apiClaims.Count == 0)
                {
                    result.AddError(ErrorCode.NotFound, "Unable to find Api claims");
                    return result;
                }

                result.Payload = apiClaims;
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
