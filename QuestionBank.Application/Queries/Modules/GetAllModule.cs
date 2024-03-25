using MediatR;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Queries.Modules
{
    public class GetAllModule : IRequest<OperationResult<IEnumerable<Module>>>
    {
        public RecordStatus? recordStatus { get; set; }
    }
    internal class GetAllModuleQueryHandler : IRequestHandler<GetAllModule, OperationResult<IEnumerable<Module>>>
    {
        private readonly IRepositoryBase<Module> _module;
        public GetAllModuleQueryHandler(IRepositoryBase<Module> module)
        {
            _module = module;
        }

        public async Task<OperationResult<IEnumerable<Module>>> Handle(GetAllModule request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<IEnumerable<Module>>();
            try
            {

                var module = request.recordStatus switch
                {
                    RecordStatus.Active => _module.Where(x => x.RecordStatus == RecordStatus.Active).ToList(),
                    RecordStatus.InActive => _module.Where(x => x.RecordStatus == RecordStatus.InActive).ToList(),
                    _ => _module.Where(x => x.RecordStatus != RecordStatus.Deleted).ToList(),
                };

                if (module is null || module.Count == 0)
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
