using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;

namespace QuestionBank.Application.Commands.UserModules
{
    public class CreateUserModule : IRequest<OperationResult<UserModule>>
    {
        public long ModuleId { get; set; }
    }
    internal class CreateClinetHandler : IRequestHandler<CreateUserModule, OperationResult<UserModule>>
    {
        private readonly IRepositoryBase<UserModule> _userModule;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public CreateClinetHandler(IRepositoryBase<UserModule> userModule, IHttpContextAccessor httpContextAccessor)
        {
            _userModule = userModule;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<UserModule>> Handle(CreateUserModule request, CancellationToken cancellationToken)
        {

            var result = new OperationResult<UserModule>();
            try
            {

                var userModule = UserModule.Create(_session.GetString("user"), request.ModuleId);
                userModule.Register(_session.GetString("user"));

                await _userModule.AddAsync(userModule);

                result.Payload = userModule;
            }
            catch (Exception e)
            {
                result.AddError(ErrorCode.ServerError, e.Message);
            }
            return result;

        }
    }
}
