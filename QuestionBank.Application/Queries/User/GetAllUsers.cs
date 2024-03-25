using MediatR;
using Microsoft.EntityFrameworkCore;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;
using QuestionBank.Infrastructure.Context;
namespace QuestionBank.Application.Queries.Users
{
    public class GetAllUsers : IRequest<OperationResult<List<IdentityUser>>>
    {
        public RecordStatus? RecordStatus { get; set; }
    }
    internal class GetAllUsersQueryHandler : IRequestHandler<GetAllUsers, OperationResult<List<IdentityUser>>>
    {
        private readonly IRepositoryBase<IdentityUser> _identityUser;
        private readonly ApplicationDbContext _context;

        public GetAllUsersQueryHandler(IRepositoryBase<IdentityUser> identityUser, ApplicationDbContext context)
        {
            _identityUser = identityUser;
            _context = context;
        }
        public async Task<OperationResult<List<IdentityUser>>> Handle(GetAllUsers request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<List<IdentityUser>>();
            try
            {

                var users = request.RecordStatus switch
                {
                    RecordStatus.Active => await _identityUser.Where(r => r.RecordStatus == RecordStatus.Active, "IdentityUserRoles", "IdentityUserRoles.Role", "IdentityUserRoles.Role.RoleClaims", "IdentityUserRoles.Role.RoleClaims.ClientClaim").ToListAsync(),
                    RecordStatus.InActive => await _identityUser.Where(r => r.RecordStatus == RecordStatus.InActive, "IdentityUserRoles", "IdentityUserRoles.Role", "IdentityUserRoles.Role.RoleClaims", "IdentityUserRoles.Role.RoleClaims.ClientClaim").ToListAsync(),
                    _ => await _identityUser.Where(r => r.RecordStatus != RecordStatus.Deleted, "IdentityUserRoles", "IdentityUserRoles.Role", "IdentityUserRoles.Role.RoleClaims", "IdentityUserRoles.Role.RoleClaims.ClientClaim").ToListAsync(),
                };

                if (users.Count == 0)
                {
                    result.AddError(ErrorCode.NotFound, "No User Data!");
                    return result;
                }
                result.Payload = users;
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
