using MediatR;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Queries.UserModules
{
    public class GetUserModuleById : IRequest<OperationResult<UserModule>>
    {
        public long Id { get; set; }
    }
    internal class GetClienByIdtQueryHandler : IRequestHandler<GetUserModuleById, OperationResult<UserModule>>
    {
        private readonly IRepositoryBase<UserModule> _userModule;
        public GetClienByIdtQueryHandler(IRepositoryBase<UserModule> userModule)
        {
            _userModule = userModule;
        }
        public async Task<OperationResult<UserModule>> Handle(GetUserModuleById request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<UserModule>();
            try
            {
                var userModule = await _userModule.FirstOrDefaultAsync(x => x.Id == request.Id && x.RecordStatus == RecordStatus.Active);

                if (userModule is null)
                {
                    result.AddError(ErrorCode.NotFound, "User Module is not found!");
                    return result;
                }
                result.Payload = userModule;
                return result;

            }
            catch (Exception ex)
            {
                result.AddError(ErrorCode.ServerError, ex.Message);
            }
            return result;
        }
    }
}
