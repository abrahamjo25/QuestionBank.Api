using QuestionBank.Application.Helpers.Common;
using QuestionBank.Application.Services.GenericRepository;
using QuestionBank.Domain.Models.Clients;
using MediatR;

namespace QuestionBank.Application.Commands.ApiClaims
{
    public class UpdateApiClaim : IRequest<OperationResult<ApiClaim>>
    {
        public long Id { get; set; }
        public string Claim { get; set; }
        public long ServiceId { get; set; }
        public bool RequiredIdToken { get; set; }
    }

    public class UpdateApiClaimHandler : IRequestHandler<UpdateApiClaim, OperationResult<ApiClaim>>
    {

        private readonly IRepositoryBase<ApiClaim> _apiClaim;
        public UpdateApiClaimHandler(IRepositoryBase<ApiClaim> apiClaim)
        {
            _apiClaim = apiClaim;
        }
        public async Task<OperationResult<ApiClaim>> Handle(UpdateApiClaim request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<ApiClaim>();
            var apiClaim = _apiClaim.Find(request.Id);

            if (apiClaim is null)
                result.AddError(ErrorCode.NotFound, "Unable to find Api Claim");

            apiClaim.Update(request.Claim, request.ServiceId, request.RequiredIdToken);
            _apiClaim.Update(apiClaim);
            result.Payload = apiClaim;
            return result;

        }
    }
}
