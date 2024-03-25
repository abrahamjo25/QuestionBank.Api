using QuestionBank.Api.Contracts.Choices.Request;
using QuestionBank.Api.Contracts.Choices.Response;
using QuestionBank.Api.Controllers.V1._0;
using QuestionBank.Application.Commands.Choices;
using QuestionBank.Application.Queries.Choices;
using QuestionBank.Domain.Models.Shared;

namespace ChoiceBank.Api.Controllers.V1._0.ChoiceBanks
{
    public class ChoiceController : BaseController
    {
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(RecordStatus? recordStatus)
        {
            var result = await _mediator.Send(new GetAllChoice { recordStatus = recordStatus });
            var choicess = _mapper.Map<List<ChoiceDetail>>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(choicess);
        }
        [HttpPost("Create")]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] ChoiceCreateRequest choicesRequest)
        {
            var command = _mapper.Map<CreateChoice>(choicesRequest);
            var result = await _mediator.Send(command);
            var choices = _mapper.Map<ChoiceDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(choices);
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetChoiceById { Id = id };
            var result = await _mediator.Send(query);
            var choices = _mapper.Map<ChoiceDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(choices);

        }
        [HttpPatch("Update")]
        [ValidateModel]
        public async Task<IActionResult> Update([FromBody] ChoiceUpdateRequest request, int id)
        {
            var command = _mapper.Map<UpdateChoice>(request);
            command.Id = id;
            var result = await _mediator.Send(command);
            var choices = _mapper.Map<ChoiceDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(choices);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(long id)
        {
            var command = new DeleteChoice { Id = id };
            var result = await _mediator.Send(command);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok();
        }
    }
}
