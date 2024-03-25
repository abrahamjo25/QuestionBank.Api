using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.Clients;

namespace QuestionBank.Application.Commands.ApiClaims
{
    public class CreateApiClaim : IRequest<OperationResult<Unit>>
    {
        public List<string> Claim { get; set; }
        public long ServiceId { get; set; }
        public bool RequireIdToken { get; set; }
    }
    internal class CreateApiClaimHandler : IRequestHandler<CreateApiClaim, OperationResult<Unit>>
    {
        private readonly IRepositoryBase<ApiClaim> _apiClaim;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public CreateApiClaimHandler(IRepositoryBase<ApiClaim> apiClaim, IHttpContextAccessor httpContextAccessor)
        {
            _apiClaim = apiClaim;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<Unit>> Handle(CreateApiClaim request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Unit>();
            var apiClaims=  new List<ApiClaim>();
            try
            {
                foreach (var item in request.Claim)
                {
                    var existingApiClaim = await _apiClaim.FirstOrDefaultAsync(x => x.ServiceId == request.ServiceId && x.Claim.Equals(item));
                    if (existingApiClaim is not null)
                        continue;

                    var apiClaim = ApiClaim.Create(item, request.ServiceId, request.RequireIdToken);
                    apiClaim.Register(_session.GetString("user"));
                    apiClaims.Add(apiClaim);
                }
                _apiClaim.AddRange(apiClaims);
                result.Payload = Unit.Value;
            }
            catch (Exception e)
            {
                result.AddError(ErrorCode.ServerError, e.Message);
            }
            return result;
        }
    }
}
