using MediatR;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.Clients;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Commands.ApiClaims
{
    public class UpdateApiClaimStatus : IRequest<OperationResult<ApiClaim>>
    {
        public long Id { get; set; }
        public RecordStatus RecordStatus { get; set; }
    }

    public class UpdateApiClaimStatusHandler : IRequestHandler<UpdateApiClaimStatus, OperationResult<ApiClaim>>
    {

        private readonly IRepositoryBase<ApiClaim> _apiClaim;
        public UpdateApiClaimStatusHandler(IRepositoryBase<ApiClaim> apiClaim)
        {
            _apiClaim = apiClaim;
        }
        public async Task<OperationResult<ApiClaim>> Handle(UpdateApiClaimStatus request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<ApiClaim>();
            var apiClaim = _apiClaim.Find(request.Id);

            if (apiClaim is null)
            {
                result.AddError(ErrorCode.NotFound, "Unable to find Api Claim");
                return result;
            }
            apiClaim.UpdateStatus((RecordStatus)request.RecordStatus);
            _apiClaim.Update(apiClaim);
            result.Payload = apiClaim;
            return result;

        }
    }
}
