using QuestionBank.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
namespace QuestionBank.Application.Commands.Services
{
    public class ActivateService : IRequest<OperationResult<Service>>
    {
        public long ServiceId { get; set; }
        public RecordStatus Status { get; set; }
    }
    internal class ActivateServiceHandler : IRequestHandler<ActivateService, OperationResult<Service>>
    {
        private readonly IRepositoryBase<Service> _service;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public ActivateServiceHandler(IRepositoryBase<Service> service, IHttpContextAccessor httpContextAccessor)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<Service>> Handle(ActivateService request, CancellationToken cancellationToken)
        {
           var result = new OperationResult<Service>();
            try
            {
                var service = await _service.FirstOrDefaultAsync(s => s.Id == request.ServiceId && s.RecordStatus != RecordStatus.Deleted);
                if (service is null)
                {
                    result.AddError(ErrorCode.NotFound, "Service not found!");
                    return result;
                }

                service.UpdateStatus(request.Status);
                service.UpdateAudit(_session.GetString("user"));

                _service.Update(service);

                result.Payload = service;
                result.Message = "Operation Success";
                
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
