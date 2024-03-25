using AutoMapper;
using Identity.Application.Helpers.Dtos;
using QuestionBank.Application.Helpers.Common;

namespace QuestionBank.Api.Controllers.V1._0
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        private IMediator _mediatorInstance;
        private IMapper _mapperInstance;
        protected IMediator _mediator => _mediatorInstance ??= HttpContext.RequestServices.GetService<IMediator>();
        protected IMapper _mapper => _mapperInstance ??= HttpContext.RequestServices.GetService<IMapper>();

        protected IActionResult HandleErrorResponse(List<Error> errors)
        {
            var apiError = new Contracts.Common.ErrorResponse();

            if (errors.Any(e => e.Code == ErrorCode.NotFound))
            {
                var error = errors.FirstOrDefault(e => e.Code == ErrorCode.NotFound);

                apiError.StatusCode = 404;
                apiError.StatusPhrase = "Not Found";
                apiError.Timestamp = DateTime.Now;
                apiError.Errors.Add(error.Message);

                return NotFound(apiError);
            }

            if (errors.Any(e => e.Code == ErrorCode.UnAuthorized))
            {
                var error = errors.FirstOrDefault(e => e.Code == ErrorCode.UnAuthorized);

                apiError.StatusCode =(int)ErrorCode.UnAuthorized;
                apiError.StatusPhrase = "UnAuthorized";
                apiError.Timestamp = DateTime.Now;
                apiError.Errors.Add(error.Message);

                return StatusCode((int)ErrorCode.UnAuthorized, apiError);
            }
            apiError.StatusCode = 400;
            apiError.StatusPhrase = "Bad request";
            apiError.Timestamp = DateTime.Now;
            errors.ForEach(e => apiError.Errors.Add(e.Message));
            return StatusCode(400, apiError);
        }
        protected IActionResult HandleTokenErrorResponse(List<Error> errors)
        {
            var clientStatus = string.Empty;
            var apiError = new OperationResult<UserTokenValidationResponse>();

            if (errors.Any(e => e.Code == ErrorCode.ServerError))
            {
                var error = errors.FirstOrDefault(e => e.Code == ErrorCode.ServerError);

                apiError.Message = "Server error";
                apiError.AddError(ErrorCode.ServerError, "Server error");
                return StatusCode(500,apiError);
            }
            clientStatus = errors.Any(x => x.Message == "User is not authorized to access the Tenant") ? "105" : clientStatus;
            clientStatus = errors.Any(x => x.Message == "User is not Authorized to access.") ? "104" : clientStatus;
            clientStatus = errors.Any(x => x.Message == "Id token is invalid.") ? "103" : clientStatus;
            clientStatus = errors.Any(x => x.Message == "Client is not Authorized.") ? "102" : clientStatus;
            clientStatus = errors.Any(x => x.Message == "Client token is invalid.") ? "101" : clientStatus;
            apiError.Message = clientStatus;
            errors.ForEach(e => apiError.AddError(ErrorCode.ServerError,e.Message));
            return StatusCode(401, apiError);
        }
    }

}
