using QuestionBank.Api.Filters;
using QuestionBank.Api.Contracts.Client.Request;
using QuestionBank.Api.Contracts.Client.Response;
using QuestionBank.Application.Commands.ApiClaims;
using QuestionBank.Application.Commands.Roles;
using QuestionBank.Application.Queries.ApiClaims;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Api.Controllers.V1._0.Client
{
    public class ApiClaimController : BaseController
    {
        [HttpPost("Create")]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] ApiClaimRequest Request)
        {
            var result = await _mediator.Send(new CreateApiClaim { Claim=Request.Claim, ServiceId= Request.ServiceId, RequireIdToken=Request.RequiredIdToken});
            //var client = _mapper.Map<ApiClaimDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result);
        }
        [HttpPost("RequiredTokenUpdate")]
        [ValidateModel]
        public async Task<IActionResult> RequiredTokenUpdate([FromBody] ApiClaimRequest Request)
        {
            //var result = await _mediator.Send(new ApiClaimWithoutIdUpdate { Claim = Request.Claim, ServiceId = Request.ServiceId, requiredIdToken = Request.RequiredIdToken });
            ////var client = _mapper.Map<ApiClaimDetail>(result.Payload);
            //return result.IsError ? HandleErrorResponse(result.Errors) : Ok("Successfuly changed");
            return Ok();
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetApiClaimById { Id = id };
            var result = await _mediator.Send(query);
            var client = _mapper.Map<ApiClaimDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(client);

        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(RecordStatus? recordStatus)
        {
            var result = await _mediator.Send(new GetAllApiClaim { RecordStatus = recordStatus });
            var clients = _mapper.Map<List<ApiClaimDetail>>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(clients);
        }
        [HttpPatch("Update")]
        [ValidateModel]
        public async Task<IActionResult> Update([FromBody] ApiClaimUpdateRequest request, int id)
        {
            var result = await _mediator.Send(new UpdateApiClaim {Id=id,Claim= request.Claim, ServiceId= request.ServiceId, RequiredIdToken  = request.RequiredIdToken});
            var client = _mapper.Map<ApiClaimDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(client);

        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(long id)
        {
            var command = new DeleteApiClaim { Id = id };
            var result = await _mediator.Send(command);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok();
        }

        [HttpPut("UpdateStatus")]
        public async Task<IActionResult> UpdateStatus(UpdateApiClaimStatusDto request)
        {
            var command = new UpdateApiClaimStatus { Id = request.Id, RecordStatus = request.RecordStatus };
            var result = await _mediator.Send(command);
            var apiClaim = _mapper.Map<ApiClaimDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(apiClaim);
        }

        [HttpGet("GetAllByServiceId")]
        public async Task<IActionResult> GetAllByServiceId(long? ServiceId,RecordStatus? recordStatus)
        {
            var result = await _mediator.Send(new GetAllApiClaimByServiceId {ServiceId=ServiceId, RecordStatus = recordStatus });
            var apiclaims = _mapper.Map<List<ApiClaimDetail>>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(apiclaims);
        }

    }
}
