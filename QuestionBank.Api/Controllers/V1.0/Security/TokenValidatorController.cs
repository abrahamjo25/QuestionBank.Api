using Identity.Api.Contracts.Security;
using Identity.Application.Commands.Validator;
using QuestionBank.Api.Contracts.Security;
using QuestionBank.Application.Commands.Validator;

namespace QuestionBank.Api.Controllers.V1._0.Security
{
    public class TokenValidatorController : BaseController
    {
        [HttpPost("ValidateAll")]
        public async Task<IActionResult> ValidateAll([FromBody] ValidateAllRequest request)
        {
            var result = await _mediator.Send(new ValidateAll
            {
                AccessToken = request.AccessToken.Trim(),
                IdToken = request.IdToken.Trim(),
                ClientResource = request.ClientResource.Trim(),
                ApiResource = request.ApiResource.Trim(),
                ServiceId = request.ServiceId,
                OrganizationCode = request.OrganizationCode,
                IsMultiTenant = request.IsMultiTenant,
                IsCompany = request.IsCompany,
                CompanyCode = request.CompanyCode,
            });
            return result.IsError ? HandleTokenErrorResponse(result.Errors) : Ok(result);
        }

        [HttpPost("ValidateEmailToken")]
        public async Task<IActionResult> ValidateEmailToken(ValidateTokenRequest request)
        {
            var result = await _mediator.Send(new ValidateEmailToken
            {
                Token = request.AccessToken,
                Email = request.Email,
                Name = request.FullName
            });
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result.Payload);
        }
        [HttpPost("Validate_Email_Token")]
        public async Task<IActionResult> ValidateEmailToken(string accesstoken, string fullName, string email)
        {
            var result = await _mediator.Send(new ValidateEmailToken
            {
                Token = accesstoken,
                Email = email,
                Name = fullName
            });
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result.Payload);
        }

        [HttpPost("GenerateEmailToken")]
        public async Task<IActionResult> GenerateEmailToken(string email, string fullName, int tokenLifeTime/*minutes*/)
        {
            var result = await _mediator.Send(new GenerateEmailToken
            {
                Email = email,
                FullName = fullName,
                TokenLifeTime = tokenLifeTime

            });
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result.Payload);

        }

        [HttpPost("Generate_Email_Token")]
        public async Task<IActionResult> GenerateEmailToken(EmailTokenRequest request)
        {
            var result = await _mediator.Send(new GenerateEmailToken
            {
                Email = request.Email,
                FullName = request.FullName,
                TokenLifeTime = request.TokenLifetime

            });
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result.Payload);

        }
    }
}
