using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Commands.Roles
{
    public class UpdateRoleStatus : IRequest<OperationResult<Role>>
    {
        public long Id { get; set; }
        public RecordStatus RecordStatus { get; set; }
    }
    internal class UpdateRoleStatusHandler : IRequestHandler<UpdateRoleStatus, OperationResult<Role>>
    {
        private readonly IRepositoryBase<Role> _role;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IPassword _passwordService;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public UpdateRoleStatusHandler(IRepositoryBase<Role> role, IPassword passwordService, IHttpContextAccessor httpContextAccessor)
        {
            _role = role;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<Role>> Handle(UpdateRoleStatus request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Role>();

            try
            {
                var role = await _role.FindAsync(request.Id);
                if (role is null)
                {
                    result.AddError(ErrorCode.NotFound, "No role found,");
                    return result;
                }
                role.UpdateStatus((RecordStatus)request.RecordStatus);
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

