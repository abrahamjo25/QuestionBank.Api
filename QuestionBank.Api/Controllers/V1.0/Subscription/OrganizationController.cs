using QuestionBank.Api.Filters;
using QuestionBank.Api.Contracts.Subscription;
using QuestionBank.Application.Commands;
using QuestionBank.Application.Queries.Roles;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Api.Controllers.V1._0.Client
{
    public class OrganizationController : BaseController
    {
        [HttpPost("Create")]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] OrganizationCreateDto request)
        {
            var result = await _mediator.Send(new CreateOrganization { Name = request.Name, Logo = request.Logo, Description = request.Description, SubscriptionId = request.SubscriptionId });
            var organization = _mapper.Map<OrganizationDetailDto>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(organization);
        }
        [HttpPatch("Update")]
        [ValidateModel]
        public async Task<IActionResult> Update([FromBody] OrganizationCreateDto request, int id)
        {
            var result = await _mediator.Send(new UpdateOrganization { Id = id, Logo = request.Logo, Description = request.Description, Name = request.Name, SubscriptionId = request.SubscriptionId });
            var organization = _mapper.Map<OrganizationDetailDto>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(organization);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(long id)
        {
            var command = new DeleteOrganization { Id = id };
            var result = await _mediator.Send(command);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok();
        }
        [HttpPut("UpdateStatus/{id}")]
        public async Task<IActionResult> UpdateStatus(UpdateStatusDto request, long id)
        {
            var command = new UpdateOrganizationStatus { Id = id, Status = request.RecordStatus };
            var result = await _mediator.Send(command);
            var subscription = _mapper.Map<OrganizationDetailDto>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(subscription);
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(RecordStatus? recordStatus)
        {
            var result = await _mediator.Send(new GetOrganizations { RecordStatus = recordStatus });
            var subscriptions = _mapper.Map<List<OrganizationDetailDto>>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(subscriptions);
        }
        [HttpGet("Get")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetOrganiztionById { Id = id };
            var result = await _mediator.Send(query);
            var client = _mapper.Map<OrganizationDetailDto>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(client);
        }
        [HttpGet("GetBysubscription")]
        public async Task<IActionResult> GetBysubscription(int id)
        {
            var query = new GetBySubscriptionId { SubscriptonId = id };
            var result = await _mediator.Send(query);
            var organizaitons = _mapper.Map<List<OrganizationDetailDto>>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(organizaitons);
        }
    }
}
