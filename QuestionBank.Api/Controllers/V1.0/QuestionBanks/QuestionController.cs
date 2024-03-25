using QuestionBank.Api.Contracts.Questions.Request;
using QuestionBank.Api.Contracts.Questions.Response;
using QuestionBank.Application.Commands.Questions;
using QuestionBank.Application.Queries.Questions;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Api.Controllers.V1._0.QuestionBanks
{
    public class QuestionController : BaseController
    {
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(RecordStatus? recordStatus)
        {
            var result = await _mediator.Send(new GetAllQuestion { recordStatus = recordStatus });
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result.Payload);
        }
        [HttpPost("Create")]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] QuestionCreateRequest questionRequest)
        {
            var command = _mapper.Map<CreateQuestion>(questionRequest);
            var result = await _mediator.Send(command);
            var question = _mapper.Map<QuestionDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(question);
        }
        [HttpPost("CreateQuestionWithChoice")]
        [ValidateModel]
        public async Task<IActionResult> CreateQuestionWithChoice([FromBody] QuestionsWithChoicesCreate questionRequest)
        {
            var command = _mapper.Map<CreateQuestionsWithChoice>(questionRequest);
            var result = await _mediator.Send(command);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result.Payload);
        }
        [HttpPatch("UpdateQuestionWithChoice/{questionId}")]
        [ValidateModel]
        public async Task<IActionResult> UpdateQuestionWithChoice(long questionId, [FromBody] QuestionsWithChoicesUpdate questionRequest)
        {
            var command = _mapper.Map<UpdateQuestionsWithChoice>(questionRequest);
            command.QuestionId = questionId;
            var result = await _mediator.Send(command);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result.Payload);
        }


        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetQuestionById { Id = id };
            var result = await _mediator.Send(query);
            var question = _mapper.Map<QuestionDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(question);

        }
        [HttpGet("GetByModuleId")]
        public async Task<IActionResult> GetByModuleId(int id)
        {
            var query = new GetByModuleId { Id = id };
            var result = await _mediator.Send(query);
            //var question = _mapper.Map<List<QuestionDetail>>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result.Payload);

        }
        [HttpPatch("Update")]
        [ValidateModel]
        public async Task<IActionResult> Update([FromBody] QuestionUpdateRequest request, int id)
        {
            var command = _mapper.Map<UpdateQuestion>(request);
            command.Id = id;
            var result = await _mediator.Send(command);
            var question = _mapper.Map<QuestionDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(question);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(long id)
        {
            var command = new DeleteQuestion { Id = id };
            var result = await _mediator.Send(command);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok();
        }
    }
}
