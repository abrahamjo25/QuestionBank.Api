using QuestionBank.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;
using Microsoft.EntityFrameworkCore;
namespace QuestionBank.Application.Queries.Roles
{
    public class GetOrganizations : IRequest<OperationResult<List<Organization>>>
    {
        public RecordStatus? RecordStatus { get; set; }
    }
    internal class GetAllOrganizationHandler : IRequestHandler<GetOrganizations, OperationResult<List<Organization>>>
    {
        private readonly IRepositoryBase<Organization> _organization;
        public GetAllOrganizationHandler(IRepositoryBase<Organization> organization)
        {
            _organization = organization;
        }

        public async Task<OperationResult<List<Organization>>> Handle(GetOrganizations request, CancellationToken cancellationToken)
        {

            var result = new OperationResult<List<Organization>>();
            try
            {

                var organization = request.RecordStatus switch
                {
                    RecordStatus.Active => await _organization.Where(x => x.RecordStatus == RecordStatus.Active).ToListAsync(),
                    RecordStatus.InActive => await _organization.Where(x => x.RecordStatus == RecordStatus.InActive).ToListAsync(),
                    _ => await _organization.Where(x => x.RecordStatus != RecordStatus.Deleted).ToListAsync(),
                };

                if (organization.Count == 0)
                {
                    result.AddError(ErrorCode.NotFound, "No Organizaiton data!");
                    return result;
                }
                result.Payload = organization;
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
