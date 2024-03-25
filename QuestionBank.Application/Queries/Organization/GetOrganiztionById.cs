using QuestionBank.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;
using Microsoft.EntityFrameworkCore;
namespace QuestionBank.Application.Queries.Roles
{
    public class GetOrganiztionById : IRequest<OperationResult<Organization>>
    {
        public long Id { get; set; }
    }
    internal class GetOrganiztionByIdHandler : IRequestHandler<GetOrganiztionById, OperationResult<Organization>>
    {
        private readonly IRepositoryBase<Organization> _role;
        public GetOrganiztionByIdHandler(IRepositoryBase<Organization> role)
        {
            _role = role;
        }
        public async Task<OperationResult<Organization>> Handle(GetOrganiztionById request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Organization>();
            try
            {
                var organization = await _role.FirstOrDefaultAsync(x => x.Id == request.Id && x.RecordStatus != RecordStatus.Deleted);
                if (organization is null)
                {
                    result.AddError(ErrorCode.NotFound, "Organization is not found!");
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
