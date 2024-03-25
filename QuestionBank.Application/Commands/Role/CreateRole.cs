using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.User;

namespace QuestionBank.Application.Commands.Roles
{
    public class CreateRole : IRequest<OperationResult<Role>>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long ClientId { get; set; }
        public List<long> Claims { get; set; }

    }
    internal class CreateRoleHandler : IRequestHandler<CreateRole, OperationResult<Role>>
    {
        private readonly IRepositoryBase<Role> _role;
        private readonly IRepositoryBase<ClientClaim> _clientClaim;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public CreateRoleHandler(IRepositoryBase<Role> role, IHttpContextAccessor httpContextAccessor, IRepositoryBase<ClientClaim> clientClaim)
        {
            _role = role;
            _clientClaim = clientClaim;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<Role>> Handle(CreateRole request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Role>();
            try
            {
                if (_role.ExistWhere(x => x.Name == request.Name))
                {
                    result.AddError(ErrorCode.RecordExist, "Role name is registerd.");
                    return result;
                }
                var role = Role.Create(request.Name, request.Description, request.ClientId);

                var getClinetclaim = _clientClaim.Where(c => c.ClientId == request.ClientId).ToList();
                var ids = getClinetclaim.Select(c => c.Id);

                foreach (var claimId in request.Claims)
                {
                    if (ids.Contains(claimId))
                    {
                        role.AddRoleClaim(new RoleClaim
                        {
                            ClientClaimId = claimId,
                            RoleId = role.Id,
                        });
                    }
                    else
                    {
                        result.AddError(ErrorCode.IdentityCreationFailed, "Role and ClientClaim's ClientId is not similar.");
                        return result;
                    }
                }
                role.Register(_session.GetString("user"));
                _role.Add(role);
                result.Payload = role;
            }
            catch (Exception e)
            {
                result.AddError(ErrorCode.ServerError, e.Message);
            }
            return result;

        }
    }
}

