
using QuestionBank.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;
using Microsoft.EntityFrameworkCore;
namespace QuestionBank.Application.Queries.Services
{
    public class GetServiceById : IRequest<OperationResult<Service>>
    {
        public long Id { get; set; }
    }

    internal class GetServiceByIdQueryHandler : IRequestHandler<GetServiceById, OperationResult<Service>>
    {
        private readonly IRepositoryBase<Service> _service;

        public GetServiceByIdQueryHandler(IRepositoryBase<Service> service)
        {
            _service = service;
        }


        public async Task<OperationResult<Service>> Handle(GetServiceById request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Service>();
            try
            {
                var service = await _service.FirstOrDefaultAsync(s => s.Id == request.Id && s.RecordStatus == RecordStatus.Active && s.RecordStatus!=RecordStatus.Deleted, "ApiClaims") ;

                if (service is null)
                {
                    result.AddError(ErrorCode.NotFound, "Service not found!");
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
