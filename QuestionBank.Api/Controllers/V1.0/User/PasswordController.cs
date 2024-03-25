using QuestionBank.Application.Commands.Users;

namespace QuestionBank.Api.Controllers.V1._0.User;
public class PasswordController : BaseController
{
    [HttpPost("ChangePassword")]
    public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequest changePasswordRequest)
    {
        var command = _mapper.Map<ChangePassword>(changePasswordRequest);
        var result = await _mediator.Send(command);
        return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result);
    }

    [HttpPost("ResetPassword")]
    public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordRequest resetPasswordRequest)
    {
        var command = _mapper.Map<ResetPassword>(resetPasswordRequest);
        var result = await _mediator.Send(command);
        return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result);
    }

    [HttpGet("ForgotPassword")]
    public async Task<IActionResult> ForgotPassword(string userName)
    {
        var query = new ForgotPassword { UserName = userName };
        var result = await _mediator.Send(query);
        result.Payload = null;
        return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result);
    }


    [HttpPost("ForgotPassword")]
    public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordRequest resetPasswordRequest)
    {
        var command = _mapper.Map<ConfirmForgotPassword>(resetPasswordRequest);
        var result = await _mediator.Send(command);
        return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result);
    }
}
