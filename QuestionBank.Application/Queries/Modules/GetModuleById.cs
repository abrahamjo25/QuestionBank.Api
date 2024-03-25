using MediatR;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Queries.Modules
{
    public class GetModuleById : IRequest<OperationResult<Module>>
    {
        public long Id { get; set; }
    }
    internal class GetModuleByIdQueryHandler : IRequestHandler<GetModuleById, OperationResult<Module>>
    {
        private readonly IRepositoryBase<Module> _module;
        public GetModuleByIdQueryHandler(IRepositoryBase<Module> module)
        {
            _module = module;
        }
        public async Task<OperationResult<Module>> Handle(GetModuleById request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Module>();
            try
            {
                var module = await _module.FirstOrDefaultAsync(x => x.Id == request.Id && x.RecordStatus == RecordStatus.Active);

                if (module is null)
                {
                    result.AddError(ErrorCode.NotFound, "Module is not found!");
                    return result;
                }
                result.Payload = module;
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
