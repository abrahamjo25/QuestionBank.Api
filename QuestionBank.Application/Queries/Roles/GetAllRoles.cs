using QuestionBank.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;
using Microsoft.EntityFrameworkCore;
namespace QuestionBank.Application.Queries.Roles
{
    public class GetAllRoles : IRequest<OperationResult<List<Role>>>
    {
        public RecordStatus? RecordStatus { get; set; }
    }
    internal class GetAllRoleHandler : IRequestHandler<GetAllRoles, OperationResult<List<Role>>>
    {
        private readonly IRepositoryBase<Role> _roles;
        public GetAllRoleHandler(IRepositoryBase<Role> roles)
        {
            _roles = roles;
        }

        public async Task<OperationResult<List<Role>>> Handle(GetAllRoles request, CancellationToken cancellationToken)
        {

            var result = new OperationResult<List<Role>>();
            try
            {

                var roles = request.RecordStatus switch
                {
                    RecordStatus.Active => await _roles.Where(x => x.RecordStatus == RecordStatus.Active, "RoleClaims", "RoleClaims.ClientClaim", "Client").ToListAsync(),
                    RecordStatus.InActive => await _roles.Where(x => x.RecordStatus == RecordStatus.InActive, "RoleClaims", "RoleClaims.ClientClaim", "Client").ToListAsync(),
                    _ => await _roles.Where(x => x.RecordStatus != RecordStatus.Deleted, "RoleClaims", "RoleClaims.ClientClaim","Client").ToListAsync(),
                };
                  
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
