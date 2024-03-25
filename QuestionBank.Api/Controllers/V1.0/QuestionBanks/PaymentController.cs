using QuestionBank.Api.Contracts.Payments;
using QuestionBank.Application.Commands.Payment;

namespace QuestionBank.Api.Controllers.V1._0.QuestionBanks
{
    public class PaymentController : BaseController
    {
        [HttpPost("Create")]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] PaymentCreateRequest request)
        {
            var command = _mapper.Map<CreatePayment>(request);
            var result = await _mediator.Send(command);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result.Payload);
        }
    }
}
