using QuestionBank.Api.Contracts.Client.Response;
using QuestionBank.Api.Contracts.Service.Request;
using QuestionBank.Api.Contracts.Service.Response;
using QuestionBank.Application.Commands;
using QuestionBank.Application.Commands.Services;
using QuestionBank.Application.Queries.Services;
using QuestionBank.Domain.Models.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuestionBank.Api.Controllers.V1._0.Service
{
    public class ServiceController : BaseController
    {
        private readonly ILogger<ServiceController> _logger;

        public ServiceController(ILogger<ServiceController> logger)
        {
            _logger = logger;
        }
        // GET: api/<ServiceController>
        [HttpGet("GetAll")]
        [ValidateModel]
        public async Task<IActionResult> GetAll(RecordStatus? recordStatus)
        {
            var query = new GetAllServices { RecordStatus = recordStatus };

            var result = await _mediator.Send(query);
            var serviceList = _mapper.Map<IEnumerable<ServiceDetailDto>>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(serviceList);
        }
        // GET api/<ServiceController>/5
        [HttpGet("GetByID")]
        [ValidateModel]
        public async Task<IActionResult> GetByID(int id)
        {
            var query = new GetServiceById { Id = id };
            var result = await _mediator.Send(query);
            var service = _mapper.Map<ServiceDetailDto>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(service);
        }

        // POST api/<ServiceController>
        [HttpPost("Create")]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] ServiceRequest request)
        {
            var command = _mapper.Map<CreateService>(request);
            var resut = await _mediator.Send(command);
            //var serviceDetail = _mapper.Map<ServiceDetailDto>(resut.Payload);
            return resut.IsError ? HandleErrorResponse(resut.Errors) : Ok(resut);
        }

        // PUT api/<ServiceController>/5
        [HttpPut("Update")]
        [ValidateModel]
        public async Task<IActionResult> Update(int id, [FromBody] ServiceRequest request)
        {
            var command = _mapper.Map<UpdateService>(request);
            command.Id = id;
            var result = await _mediator.Send(command);
            var serviceDetail = _mapper.Map<ServiceDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(serviceDetail);
        }
        [HttpPut("ActivateDeactivateService")]
        [ValidateModel]
        public async Task<IActionResult> ActivateDeactivateService([FromBody] ActivateDeactivateServiceRequest request)
        {
            var command = _mapper.Map<UpdateSubscriptionStatus>(request);
            var result = await _mediator.Send(command);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(long id)
        {
            var result = await _mediator.Send(new DeleteService { Id = id });
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok();
        }
    }
}
