using MediatR;
using QuestionBank.Application.Helpers.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Application.Commands.Validator
{
    public class ValidateEmailToken : IRequest<OperationResult<bool>>
    {
        public string Token { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
    internal class ValidatePasswordTokenHandler : IRequestHandler<ValidateEmailToken, OperationResult<bool>>
    {
        private readonly ITokenhandler _tokenhandler;
        public ValidatePasswordTokenHandler(ITokenhandler _tokenHandler) => this._tokenhandler = _tokenHandler;
        public async Task<OperationResult<bool>> Handle(ValidateEmailToken request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<bool>();
            try
            {
                if (! await _tokenhandler.ValidateToken(request.Token)) //decrypt and validate access token
                {
                    result.Payload = false;
                    return result;
                }
                var claims = await _tokenhandler.GetClaims(request.Token); // get claims from the tokene
                if (claims.Exists(x => x.Type == "email" && x.Value.Trim().ToLower() == request.Email.Trim().ToLower()) &&
                    claims.Exists(x => x.Type == "name" && x.Value.Trim().ToLower() == request.Name.Trim().ToLower()))
                {
                    result.Payload = true;
                    return result;
                }
                result.Payload = false;
                return result;

            }
            catch (Exception ex)
            {
                result.AddError(ErrorCode.ServerError, ex.Message);
                return result;
            }
            return result;
        }
    }
}
