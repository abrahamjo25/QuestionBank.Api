using QuestionBank.Api.Filters;
using QuestionBank.Api.Contracts.Subscription;
using QuestionBank.Application;
using QuestionBank.Application.Commands;
using QuestionBank.Application.Queries.Roles;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Api.Controllers.V1._0.Client
{
    public class SubscriptionController : BaseController
    {
        [HttpPost("Create")]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] SubscriptionDto request)
        {
            var result = await _mediator.Send(new CreateSubscription { Name = request.Name, Code = request.Code, Description= request.Description});
            var subscription = _mapper.Map<SubscriptionDetailDto>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(subscription);
        }
        [HttpPatch("Update")]
        [ValidateModel]
        public async Task<IActionResult> Update([FromBody] SubscriptionDto request, int id)
        {
            var result = await _mediator.Send(new UpdateSubscription { Id = id, Code = request.Code, Description=request.Description,Name= request.Name });
            var subscription = _mapper.Map<SubscriptionDetailDto>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(subscription);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(long id)
        {
            var command = new DeleteSubscription { Id = id };
            var result = await _mediator.Send(command);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok();
        }
        [HttpPut("UpdateStatus/{id}")]
        public async Task<IActionResult> UpdateStatus(UpdateStatusDto request, long id )
        {
            var command = new UpdateSubscriptionStatus { Id = id, Status = request.RecordStatus };
            var result = await _mediator.Send(command);
            var subscription = _mapper.Map<SubscriptionDetailDto>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(subscription);
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(RecordStatus? recordStatus)
        {
            var result = await _mediator.Send(new GetAllSubscription { RecordStatus = recordStatus });
            var subscriptions = _mapper.Map<List<SubscriptionDetailDto>>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(subscriptions);
        }
        [HttpGet("Get")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetSubscription { Id = id };
            var result = await _mediator.Send(query);
            var client = _mapper.Map<SubscriptionDetailDto>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(client);
        }
    }
}
