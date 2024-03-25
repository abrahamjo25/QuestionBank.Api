using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;

namespace QuestionBank.Application.Commands.Modules
{
    public class CreateModule : IRequest<OperationResult<Module>>
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Price { get; set; }
        public int Discount { get; set; }
        public int CourseId { get; set; }
    }
    internal class CreateClinetHandler : IRequestHandler<CreateModule, OperationResult<Module>>
    {
        private readonly IRepositoryBase<Module> _module;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public CreateClinetHandler(IRepositoryBase<Module> module, IHttpContextAccessor httpContextAccessor)
        {
            _module = module;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<Module>> Handle(CreateModule request, CancellationToken cancellationToken)
        {

            var result = new OperationResult<Module>();
            try
            {

                var module = Module.Create(request.Name, request.Description,request.Price,request.Discount,request.CourseId);
                module.Register(_session.GetString("user"));

                await _module.AddAsync(module);

                result.Payload = module;
            }
            catch (Exception e)
            {
                result.AddError(ErrorCode.ServerError, e.Message);
            }
            return result;

        }
    }
}
