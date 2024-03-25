using QuestionBank.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;
using Microsoft.EntityFrameworkCore;
namespace QuestionBank.Application.Queries.Roles
{
    public class GetByClientId : IRequest<OperationResult<List<Role>>>
    {
        public long ClientId { get; set; }
    }
    internal class GetByClientIdHandler : IRequestHandler<GetByClientId, OperationResult<List<Role>>>
    {
        private readonly IRepositoryBase<Role> _roles;
        public GetByClientIdHandler(IRepositoryBase<Role> roles)
        {
            _roles = roles;
        }

        public async Task<OperationResult<List<Role>>> Handle(GetByClientId request, CancellationToken cancellationToken)
        {

            var result = new OperationResult<List<Role>>();
            try
            {

                var roles = await _roles.Where(x => x.RecordStatus != RecordStatus.Deleted && x.ClientId== request.ClientId, "RoleClaims", "RoleClaims.ClientClaim").ToListAsync();
                if (roles.Count == 0)
                {
                    result.AddError(ErrorCode.NotFound, "No roles data!");
                    return result;
                }
                result.Payload = roles;
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
