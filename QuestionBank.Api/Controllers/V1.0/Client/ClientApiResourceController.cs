using QuestionBank.Api.Contracts.Client.Request;
using QuestionBank.Application.Commands.ClientApiResource;
using QuestionBank.Application.Queries.ApiClaims;

namespace QuestionBank.Api.Controllers.V1._0.Client
{
    public class ClientApiResourceController : BaseController
    {
        [HttpPost("Create")]
        [ValidateModel]
        public async Task<IActionResult> CreateClient([FromBody] ClientClaimApiResourceRequest request)
        {
            var claims = await _mediator.Send(new GetAllApiClaim());
            List<long> apiclaimList = new List<long>();
            foreach (var claim in claims.Payload)
            {
                apiclaimList.Add(claim.Id);
            }
            var result = await _mediator.Send(new CreateClientApiResource { ClientId = request.ClientId, ApiClaimId = apiclaimList });
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok();
        }
    }
}






