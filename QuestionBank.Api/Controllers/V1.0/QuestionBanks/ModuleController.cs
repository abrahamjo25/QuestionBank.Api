using QuestionBank.Api.Contracts.Modules.Request;
using QuestionBank.Api.Contracts.Modules.Response;
using QuestionBank.Application.Commands.Modules;
using QuestionBank.Application.Queries.Modules;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Api.Controllers.V1._0.QuestionBanks
{
    public class ModuleController : BaseController
    {
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(RecordStatus? recordStatus)
        {
            var result = await _mediator.Send(new GetAllModule { recordStatus = recordStatus });
            var courses = _mapper.Map<List<ModuleDetail>>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(courses);
        }
        [HttpPost("Create")]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] ModuleCreateRequest courseRequest)
        {
            var command = _mapper.Map<CreateModule>(courseRequest);
            var result = await _mediator.Send(command);
            var course = _mapper.Map<ModuleDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(course);
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(long id)
        {
            var query = new GetModuleById { Id = id };
            var result = await _mediator.Send(query);
            var course = _mapper.Map<ModuleDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(course);

        }
        [HttpGet("GetByCourseId")]
        public async Task<IActionResult> GetByCourseId(long id)
        {
            var query = new GetByCourseId { Id = id };
            var result = await _mediator.Send(query);
            var course = _mapper.Map< List<ModuleDetail>>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(course);

        }
        
        [HttpGet("NewCourseModule")]
        public async Task<IActionResult> NewCourseModule(long id)
        {
            var query = new NewCourseModule { Id = id };
            var result = await _mediator.Send(query);
            var course = _mapper.Map< List<ModuleDetail>>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(course);

        }
        [HttpPatch("Update")]
        [ValidateModel]
        public async Task<IActionResult> Update([FromBody] ModuleUpdateRequest request, int id)
        {
            var command = _mapper.Map<UpdateModule>(request);
            command.Id = id;
            var result = await _mediator.Send(command);
            var course = _mapper.Map<ModuleDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(course);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(long id)
        {
            var command = new DeleteModule { Id = id };
            var result = await _mediator.Send(command);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok();
        }
    }
}
