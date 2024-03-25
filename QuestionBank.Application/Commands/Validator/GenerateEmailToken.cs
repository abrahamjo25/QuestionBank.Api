using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using QuestionBank.Application.Helpers.Common;

namespace QuestionBank.Application.Commands.Validator
{
    public class GenerateEmailToken : IRequest<OperationResult<string>>
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int TokenLifeTime { get; set; }
    }
    internal class GenerateEmailTokenHandler : IRequestHandler<GenerateEmailToken, OperationResult<string>>
    {
        private readonly ITokenhandler _tokenService;
        public GenerateEmailTokenHandler(ITokenhandler _tokenService) => this._tokenService = _tokenService;
        public async Task<OperationResult<string>> Handle(GenerateEmailToken request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<string>();
            if (string.IsNullOrEmpty(request.Email) || string.IsNullOrEmpty(request.FullName))
                result.AddError(ErrorCode.ServerError, "Email and Name are mandatory.");
            if (request.TokenLifeTime <= 1)
                result.AddError(ErrorCode.ServerError, "Token LifeTime cant be lessthan or equal to zero.");
            if (result.Errors.Count > 0)
                return result;
            result.Payload =await  GetJwtString(request.Email, request.FullName, request.TokenLifeTime);

            return result;
        }
        private async Task<string> GetJwtString(string email, string fullName, int tokenLifeTime)
        {
            var claims = new[]
                {
            new Claim("email",email),
             new Claim("name",fullName),
             }.ToList();
            var token = await _tokenService.CreateSecurityToken(claims, tokenLifeTime);
            return await _tokenService.WriteToken(token);
        }
    }
}
