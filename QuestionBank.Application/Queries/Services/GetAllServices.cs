using QuestionBank.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;
using Microsoft.EntityFrameworkCore;
namespace QuestionBank.Application.Queries.Services
{
    public class GetAllServices : IRequest<OperationResult<List<Service>>>
    {
        public RecordStatus? RecordStatus { get; set; }
    }
    internal class GetAllServicesQueryHandler : IRequestHandler<GetAllServices, OperationResult<List<Service>>>
    {
        private readonly IRepositoryBase<Service> _service;

        public GetAllServicesQueryHandler(IRepositoryBase<Service> service)
        {
            _service = service;
        }
        public async Task<OperationResult<List<Service>>> Handle(GetAllServices request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<List<Service>>();

            try
            {
                var service = request.RecordStatus switch
                {
                    RecordStatus.Active => await _service.Where(s => s.RecordStatus == RecordStatus.Active, "ApiClaims").ToListAsync(),
                    RecordStatus.InActive => await _service.Where(s => s.RecordStatus == RecordStatus.InActive, "ApiClaims").ToListAsync(),
                    _ => await _service.Where(s => s.RecordStatus != RecordStatus.Deleted, "ApiClaims").ToListAsync(),
                };

                if (service.Count == 0)
                {
                    result.AddError(ErrorCode.NotFound, "No Service Data");
                    return result;
                }

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
