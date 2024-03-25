using QuestionBank.Application.Commands.Validator;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Application.Helpers.Dtos;
using QuestionBank.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.OpenApi.Any;
using Identity.Application.Commands.Validator;
using Identity.Application.Helpers.Dtos;

namespace QuestionBank.Api.Filters
{
    public class AuthorizationHandler : IAuthorizationFilter
    {
        private readonly IMediator _mediator;
        private readonly ITokenhandler _tokenhandler;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private static string _enviromentVariable = Environment.GetEnvironmentVariable("IDENTITYSERVICEID");
        private static long _serviceId = string.IsNullOrEmpty(_enviromentVariable) ? 1 : Convert.ToInt64(_enviromentVariable);
        public AuthorizationHandler(ITokenhandler tokenHandler, IHttpContextAccessor httpContextAccessor, IMediator mediator)
        {
            _mediator = mediator;
            _httpContextAccessor = httpContextAccessor;
            _tokenhandler = tokenHandler;
        }
        public List<string> Anonymous = new List<string>
        {
            "Client-Login",
            "Client-CreateClient",
            "ApiClaim-Create",
            "ApiClaim-GetAll",
            "ApiClaim-GetById",
            "ClientClaim-GetAll",
            "ClientApiResource-Create",
            "TokenValidator-ValidateAll",
            "TokenValidator-CreateUser",
            "Actions-IdentityClaimSeeder",
            "ApiClaim-RequiredTokenUpdate",
            "ClientApiResource-CreateClient",
            "Password-ForgotPassword",
            "User-CreateUser",
            "User-CompanyUser",
            "Question-GetAll",
            "Question-Create",
        };
        public void OnAuthorization(AuthorizationFilterContext context)
      {

            if (context != null && context?.ActionDescriptor is ControllerActionDescriptor descriptor)
            {
                //get api resource
                string apiClaim = String.Format("{0}-{1}", descriptor.ControllerName, descriptor.ActionName);

                //get header values
                var serviceKey = context.HttpContext.Request.Headers["Servicekey"].ToString();
                var accessToken = context.HttpContext.Request.Headers["accessToken"].ToString();
                var idToken = context.HttpContext.Request.Headers["idToken"].ToString();
                var clientClaim = context.HttpContext.Request.Headers["clientClaim"].ToString();

                if (serviceKey != "86rIsmabiYR0OuW1B6NHovQsmWB8")
                {
                    if (!Anonymous.Contains(apiClaim))
                    {
                        if (string.IsNullOrEmpty(accessToken))
                            context.Result = new UnauthorizedObjectResult(new { message = "Access token is empty." });
                        else
                        {
                            var isValidRequest = _mediator.Send(new ValidateAll
                            {
                                AccessToken = accessToken.Trim(),
                                IdToken = idToken.Trim(),
                                ClientResource = clientClaim.Trim(),
                                ApiResource = apiClaim.Trim(),
                                ServiceId = _serviceId,

                            }).Result;
                            if (isValidRequest.IsError)
                                context.Result = new UnauthorizedObjectResult(HandleTokenErrorResponse(isValidRequest.Errors));
                            else
                            {
                                _httpContextAccessor?.HttpContext?.Session.SetString("client", isValidRequest.Payload.ClientId);
                                _httpContextAccessor?.HttpContext?.Session.SetString("user", isValidRequest.Payload.UserId);
                                _httpContextAccessor?.HttpContext?.Session.SetString("company", Convert.ToString(isValidRequest.Payload.IsCompany));
                            }

                        }
                    }
                }
            }

        }
        protected OperationResult<UserTokenValidationResponse> HandleTokenErrorResponse(List<Error> errors)
        {
            var clientStatus = string.Empty;
            var apiError = new OperationResult<UserTokenValidationResponse>();
            clientStatus = errors.Any(x => x.Message == "User is not Authorized to access.") ? "104" : clientStatus;
            clientStatus = errors.Any(x => x.Message == "Id token is invalid.") ? "103" : clientStatus;
            clientStatus = errors.Any(x => x.Message == "Client is not Authorized.") ? "102" : clientStatus;
            clientStatus = errors.Any(x => x.Message == "Client token is invalid.") ? "101" : clientStatus;
            apiError.Message = clientStatus;
            errors.ForEach(e => apiError.AddError(ErrorCode.ServerError, e.Message));
            return apiError;
        }
    }
}