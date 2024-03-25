using QuestionBank.Api.Contracts.Client.Request;
using QuestionBank.Api.Contracts.Client.Response;
using QuestionBank.Application.Commands.Clients;
using QuestionBank.Application.Queries.Clients;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Api.Controllers.V1._0.User
{

    public class ClientController : BaseController
    {

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(RecordStatus? recordStatus)
        {
            var result = await _mediator.Send(new GetAllClient { recordStatus = recordStatus });
            var clients = _mapper.Map<List<ClientDetails>>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(clients);
        }

        [HttpPost("Create")]
        [ValidateModel]
        public async Task<IActionResult> CreateClient([FromBody] ClientRequest clientRequest)
        {
            var command = _mapper.Map<CreateClient>(clientRequest);
            var result = await _mediator.Send(command);
            var client = _mapper.Map<ClientDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(client);
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetClientById { Id = id };
            var result = await _mediator.Send(query);
            var client = _mapper.Map<ClientDetails>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(client);

        }
        [HttpPatch("Update")]
        [ValidateModel]
        public async Task<IActionResult> UpdateClient([FromBody] ClientUpdateRequest request, int id)
        {
            var command = _mapper.Map<UpdateClient>(request);
            command.Id = id;
            var result = await _mediator.Send(command);
            var client = _mapper.Map<ClientDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(client);
        }
        [HttpPut("ActivateDeactivateClient")]
        [ValidateModel]
        public async Task<IActionResult> ActivateDeactivateClient([FromBody] ActivateDeactivateClientRequest request)
        {
            var command = _mapper.Map<ActivateClient>(request);
            var result = await _mediator.Send(command);
            var clientDetail = _mapper.Map<ClientDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(clientDetail);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteClient(long id)
        {
            var command = new DeleteClient { Id = id };
            var result = await _mediator.Send(command);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok();
        }

        [HttpPost("Login")]
        [ValidateModel]
        public async Task<IActionResult> Login([FromBody] ClientLogin request)
        {
            var command = new LoginClient { ClientId = request.ClientId, ClientSecret = request.ClientSecret };
            var result = await _mediator.Send(command);
            var loginResponse = _mapper.Map<ClientLoginResponse>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(loginResponse);
        }
        [HttpPost("RefreshToken")]
        [ValidateModel]
        public async Task<IActionResult> RefreshToken(string refreshToken)
        {
            var command = new ClientRefreshToken { RefreshToken = refreshToken };
            var result = await _mediator.Send(command);
            var loginResponse = _mapper.Map<ClientLoginResponse>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(loginResponse);
        }

        [HttpPost("TokenRefresh")]
        [ValidateModel]
        public async Task<IActionResult> RefreshToken(ClientRefreshTokenRequest refreshToken)
        {
            var command = new ClientRefreshToken { RefreshToken = refreshToken.token };
            var result = await _mediator.Send(command);
            var loginResponse = _mapper.Map<ClientLoginResponse>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(loginResponse);
        }
    }
}
