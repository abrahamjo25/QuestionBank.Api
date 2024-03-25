using QuestionBank.Api.Filters;
using QuestionBank.Application.Commands.Roles;
using QuestionBank.Application.Queries.Roles;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Api.Controllers.V1._0.User
{

    public class RoleController : BaseController
    {
        [HttpPost("Create")]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] RoleRequest request)
        {
            var command = _mapper.Map<CreateRole>(request);
            var result = await _mediator.Send(command);
            var roleDetail = _mapper.Map<RoleDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(roleDetail);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(RecordStatus? recordStatus)
        {
            var query = new GetAllRoles { RecordStatus = recordStatus };
            var result = await _mediator.Send(query);
            var roleDetails = _mapper.Map<List<RoleDetail>>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(roleDetails);
        }

       [HttpGet("GetByClientId")]
        public async Task<IActionResult> GetByClientId(long clientId)
        {
            var query = new GetByClientId { ClientId=clientId };
            var result = await _mediator.Send(query);
            var roleDetails = _mapper.Map<List<RoleDetail>>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(roleDetails);
        }

       
        [HttpGet("GetById")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetRoleById { Id = id };
            var result = await _mediator.Send(query);
            var roleDetail = _mapper.Map<RoleDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(roleDetail);
        }
        [HttpPut("Update")]

        public async Task<IActionResult> Update([FromBody] RoleRequest request, int id)
        {
            var command = _mapper.Map<UpdateRole>(request);
            command.Id = id;
            var result = await _mediator.Send(command);
            var clientClaim = _mapper.Map<RoleDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(clientClaim);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(long id)
        {
            var result = await _mediator.Send(new DeleteRole { Id = id });
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok();
        }
        [HttpPut("UpdateStatus")]
        public async Task<IActionResult> UpdateStatus([FromBody] UpdateRoleStatusDto request)
        {
            var command = new UpdateRoleStatus { Id = request.Id, RecordStatus = request.RecordStatus };
            var result = await _mediator.Send(command);
            var clientClaim = _mapper.Map<RoleDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(clientClaim);
        }


    }
}
