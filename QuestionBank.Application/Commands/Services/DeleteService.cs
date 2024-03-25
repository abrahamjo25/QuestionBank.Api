using QuestionBank.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
namespace QuestionBank.Application.Commands.Services
{
    public class DeleteService : IRequest<OperationResult<bool>>
    {
        public long Id { get; set; }
        public RecordStatus? RecordStatus { get; set; }
    }
    internal class DeleteServiceHandler : IRequestHandler<DeleteService, OperationResult<bool>>
    {
        private readonly IRepositoryBase<Service> _service;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public DeleteServiceHandler(IRepositoryBase<Service> service, IHttpContextAccessor httpContextAccessor)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<OperationResult<bool>> Handle(DeleteService request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<bool>();
            try
            {

                var service = await _service.FirstOrDefaultAsync(x => x.Id == request.Id, "ApiClaims");
                if (service is null)
                {
                    result.AddError(ErrorCode.NotFound, "Service not found");
                    return result;
                }
                if (service.IsReadOnly)
                {
                    result.AddError(ErrorCode.ValidationError, "Cannot Delete Default System Data");
                    return result;
                }
              
                service.UpdateStatus(RecordStatus.Deleted);
                service.ApiClaims.ToList().ForEach(s => s.RecordStatus = RecordStatus.Deleted);
                _service.Update(service);
            }
            catch (Exception ex)
            {
                result.AddError(ErrorCode.ServerError, ex.Message);
            }
            return result;
        }
    }
}
