using MediatR;
using Microsoft.EntityFrameworkCore;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.Clients;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Queries.ApiClaims
{
    public class GetAllApiClaimByServiceId : IRequest<OperationResult<List<ApiClaim>>>
    {
        public long? ServiceId { get;  set; }
        public RecordStatus? RecordStatus { get; set; }
    }
    internal class GetAllApiClaimByServiceIdHandler : IRequestHandler<GetAllApiClaimByServiceId, OperationResult<List<ApiClaim>>>
    {
        private readonly IRepositoryBase<ApiClaim> _apiClaim;
        public GetAllApiClaimByServiceIdHandler(IRepositoryBase<ApiClaim> apiClaim) => _apiClaim = apiClaim;
        public async Task<OperationResult<List<ApiClaim>>> Handle(GetAllApiClaimByServiceId request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<List<ApiClaim>>();
            try
            {
                var apiClaims = request.RecordStatus switch
                {
                    RecordStatus.Active => await _apiClaim.Where(s => s.RecordStatus == RecordStatus.Active && s.ServiceId==request.ServiceId, "Service").ToListAsync(),
                    RecordStatus.InActive => await _apiClaim.Where(s => s.RecordStatus == RecordStatus.InActive && s.ServiceId == request.ServiceId, "Service").ToListAsync(),
                    _ => await _apiClaim.Where(s => s.RecordStatus != RecordStatus.Deleted && s.ServiceId == request.ServiceId, "Service").ToListAsync(),
                };
                if (apiClaims.Count == 0)
                {
                    result.AddError(ErrorCode.NotFound, "Unable to find Api claims for this service");
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
