using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Commands.Modules
{
    public class DeleteModule : IRequest<OperationResult<bool>>
    {
        public long Id { get; set; }
    }
    internal class DeleteModuleHandler : IRequestHandler<DeleteModule, OperationResult<bool>>
    {
        private readonly IRepositoryBase<Module> _module;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public DeleteModuleHandler(IRepositoryBase<Module> module, IHttpContextAccessor httpContextAccessor)
        {
            _module = module;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<bool>> Handle(DeleteModule request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<bool>();
            try
            {
                var module = _module.Find(request.Id);
                if (module is null)
                {
                    result.AddError(ErrorCode.NotFound, "Module not found");
                    return result;
                }
                if (module.IsReadOnly)
                {
                    result.AddError(ErrorCode.ValidationError, "Cannot Delete Default System Module");
                    return result;
                }
                module.UpdateStatus(RecordStatus.Deleted);
                module.UpdateAudit(_session.GetString("user"));

                _module.Update(module);
            }
            catch (Exception ex)
            {
                result.AddError(ErrorCode.ServerError, ex.Message);
            }
            return result;
        }
    }
}
