using QuestionBank.Api.Contracts.UserModule.Request;
using QuestionBank.Api.Contracts.UserModule.Response;
using QuestionBank.Application.Commands.UserModules;
using QuestionBank.Application.Queries.UserModules;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Api.Controllers.V1._0.QuestionBanks
{
    public class UserModuleController : BaseController
    {
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(RecordStatus? recordStatus)
        {
            var result = await _mediator.Send(new GetAllUserModule { recordStatus = recordStatus });
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result.Payload);
        }
        [HttpPost("Create")]
        [ValidateModel]
        public async Task<IActionResult> Create(long ModuleId)
        {
            var command = new CreateUserModule { ModuleId = ModuleId };
            var result = await _mediator.Send(command);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result.Payload);
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetUserModuleById { Id = id };
            var result = await _mediator.Send(query);
            var userModule = _mapper.Map<UserModuleDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(userModule);

        }
    }
}
