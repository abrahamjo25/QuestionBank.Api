using QuestionBank.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;
using Microsoft.EntityFrameworkCore;
namespace QuestionBank.Application.Queries.Roles
{
    public class GetRoleById : IRequest<OperationResult<Role>>
    {
        public long Id { get; set; }
    }
    internal class GetRoleByIdHandler : IRequestHandler<GetRoleById, OperationResult<Role>>
    {
        private readonly IRepositoryBase<Role> _role;
        public GetRoleByIdHandler(IRepositoryBase<Role> role)
        {
            _role = role;
        }
        public async Task<OperationResult<Role>> Handle(GetRoleById request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Role>();
            try
            {
              
                var role = await _role.FirstOrDefaultAsync(x => x.Id == request.Id && x.RecordStatus != RecordStatus.Deleted, "RoleClaims", "RoleClaims.ClientClaim", "RoleClaims.ClientClaim.Client");


                if (role is null)
                {
                    result.AddError(ErrorCode.NotFound, "Role is not found!");
                    return result;
                }
                result.Payload = role;
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
