using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;
namespace QuestionBank.Application.Commands.Services
{
    public class UpdateService : IRequest<OperationResult<Service>>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    internal class UpdateServiceHandler : IRequestHandler<UpdateService, OperationResult<Service>>
    {
        private readonly IRepositoryBase<Service> _service;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public UpdateServiceHandler(IRepositoryBase<Service> service, IHttpContextAccessor httpContextAccessor)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<Service>> Handle(UpdateService request, CancellationToken cancellationToken)
        {
           var result = new OperationResult<Service>();
            try
            {
                var service = await _service.FirstOrDefaultAsync(s => s.Id == request.Id);
                var service_id = await _service.FirstOrDefaultAsync(s => s.Name == request.Name);
                if (service is null)
                {
                    result.AddError(ErrorCode.NotFound, "No service found!");
                    return result;
                }
                if (_service.ExistWhere(s => s.Name ==service.Name) && service_id.Id != request.Id)
                {
                    result.AddError(ErrorCode.RecordExist, "Service Name must be unique!");
                    return result;
                }

                service.UpdateService(request.Name, request.Description);

                service.UpdateAudit(_session.GetString("user"));

                _service.Update(service);

                result.Payload = service;
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
