using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;
using QuestionBank.Domain.Models.User;

namespace QuestionBank.Application.Commands.Roles
{
    public class UpdateRole : IRequest<OperationResult<Role>>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long ClientId { get; set; }
        public List<long> Claims { get; set; }
    }
    internal class UpdateRoleHandler : IRequestHandler<UpdateRole, OperationResult<Role>>
    {
        private readonly IRepositoryBase<Role> _role;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public UpdateRoleHandler(IRepositoryBase<Role> role,  IHttpContextAccessor httpContextAccessor)
        {
            _role = role;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<Role>> Handle(UpdateRole request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Role>();

            try
            {

                var role = await _role.FirstOrDefaultAsync(x => x.Id == request.Id, "RoleClaims");

                if (role is null)
                {
                    result.AddError(ErrorCode.NotFound, "No role found,");
                    return result;
                }
                    if (role.Name == request.Name && role.ClientId == request.ClientId && role.Id!=request.Id && role.RecordStatus != RecordStatus.Deleted)
                    {
                        result.AddError(ErrorCode.NotFound, "Role Name for this client already exists");
                        return result;
                    }
         

                role.RoleClaims.Clear();
                role.Update(request.Name, request.Description, request.ClientId);
                request.Claims.ForEach(claimId =>
                {
                    role.AddRoleClaim(new RoleClaim
                    {
                        ClientClaimId = claimId,
                        RoleId = role.Id,
                    });
                });
                role.UpdateAudit(_session.GetString("user"));

                _role.Update(role);
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
