using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Commands.Roles
{
    public class DeleteRole : IRequest<OperationResult<bool>>
    {
        public long Id { get; set; }
    }
    internal class DeleteRoleHandler : IRequestHandler<DeleteRole, OperationResult<bool>>
    {
        private readonly IRepositoryBase<Role> _role;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public DeleteRoleHandler(IRepositoryBase<Role> role, IHttpContextAccessor httpContextAccessor)
        {
            _role = role;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<bool>> Handle(DeleteRole request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<bool>();
            try
            {

                var role = await _role.FirstOrDefaultAsync(x => x.Id == request.Id, "RoleClaims");
                if (role is null)
                {
                    result.AddError(ErrorCode.NotFound, "role not found");
                    return result;
                }
                if (role.IsReadOnly)
                {
                    result.AddError(ErrorCode.ValidationError, "Cannot Delete System Role");
                    return result;
                }

                role.UpdateStatus(RecordStatus.Deleted);
                role.UpdateAudit(_session.GetString("user"));
                _role.Update(role);

            }
            catch (Exception ex)
            {
                result.AddError(ErrorCode.ServerError, ex.Message);
            }
            return result;
        }
    }
}
