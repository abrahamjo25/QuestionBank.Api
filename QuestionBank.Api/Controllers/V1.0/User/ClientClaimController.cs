using QuestionBank.Application.Commands.ClientClaims;
using QuestionBank.Application.Queries.ClientClaims;

namespace QuestionBank.Api.Controllers.V1._0.User
{

    public class ClientClaimController : BaseController
    {

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllClientClaim());
            var clientClaims = _mapper.Map<List<ClientClaimDetail>>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(clientClaims);
        }

        [HttpPost("Create")]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] ClientClaimRequest clientclaimRequest)
        {
            var command = _mapper.Map<CreateClientClaim>(clientclaimRequest);
            var result = await _mediator.Send(command);
            var clientClaim = _mapper.Map<ClientClaimDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(clientClaim);
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetClientClaimById { Id = id };
            var result = await _mediator.Send(query);
            var clientClaim = _mapper.Map<ClientClaimDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(clientClaim);

        }
        [HttpGet("GetByClientId")]
        public async Task<IActionResult> GetByClientId(int ClientId)
        {
            var result = await _mediator.Send(new GetClientClaimByClientId { CientId = ClientId });
            var clientClaims = _mapper.Map<List<ClientClaimDetail>>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(clientClaims);

        }
        [HttpPatch("Update")]

        public async Task<IActionResult> Update([FromBody] ClientClaimRequest request, int id)
        {
            var command = _mapper.Map<UpdateClientClaim>(request);
            command.Id = id;
            var result = await _mediator.Send(command);
            var clientClaim = _mapper.Map<ClientClaimDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(clientClaim);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(long id)
        {
            var command = new DeleteClientClaim { Id = id };
            var result = await _mediator.Send(command);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok();
        }

        [HttpPut("UpdateStatus")]
        public async Task<IActionResult> UpdateStatus([FromBody] UpdateClientClaimStatusDto request)
        {
            var command = new UpdateClientClaimStatus { Id = request.Id, RecordStatus = request.RecordStatus };
            var result = await _mediator.Send(command);
            var clientClaim = _mapper.Map<ClientClaimDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(clientClaim);
        }
    }
}
