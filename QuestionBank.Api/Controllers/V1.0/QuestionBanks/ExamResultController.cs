using QuestionBank.Api.Contracts.ExamResults.Request;
using QuestionBank.Application.Commands.ExamResults;
using QuestionBank.Application.Queries.ExamResults;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Api.Controllers.V1._0.QuestionBanks
{
    public class ExamResultController : BaseController
    {
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(long ModuleId)
        {
            var result = await _mediator.Send(new GetAllExamResult { ModuleId = ModuleId });
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result.Payload);
        }
        [HttpPost("Create")]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] ExamResultCreateRequest request)
        {
            var command = _mapper.Map<CreateExamResult>(request);
            var result = await _mediator.Send(command);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result.Payload);
        }
    }
}
