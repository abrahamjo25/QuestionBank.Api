using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;

namespace QuestionBank.Application.Commands.Modules
{
    public class UpdateModule : IRequest<OperationResult<Module>>
    {
        public long Id { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Price { get; set; }
        public int Discount { get; set; }

    }
    internal class UpdateModuleHandler : IRequestHandler<UpdateModule, OperationResult<Module>>
    {
        private readonly IRepositoryBase<Module> _module;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public UpdateModuleHandler(IRepositoryBase<Module> module, IHttpContextAccessor httpContextAccessor)
        {
            _module = module;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<Module>> Handle(UpdateModule request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Module>();

            try
            {
                var module = await _module.FindAsync(request.Id);

                if (module is null)
                {
                    result.AddError(ErrorCode.NotFound, "Module Not found!");
                    return result;
                }

                module.Update(request.Name, request.Description, request.Price, request.Discount);
                module.UpdateAudit(_session.GetString("user"));
                _module.Update(module);
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
