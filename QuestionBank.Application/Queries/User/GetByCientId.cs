using QuestionBank.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;
using Microsoft.EntityFrameworkCore;
namespace QuestionBank.Application.Queries.Users
{
    public class GetByClientId : IRequest<OperationResult<List<IdentityUser>>>
    {
        public long ClientId { get; set; }
    }
    internal class GetByClientIdHandler : IRequestHandler<GetByClientId, OperationResult<List<IdentityUser>>>
    {
        private readonly IRepositoryBase<IdentityUser> _identityUser;
        public GetByClientIdHandler(IRepositoryBase<IdentityUser> identityUser)
        {
            _identityUser = identityUser;
        }

        public async Task<OperationResult<List<IdentityUser>>> Handle(GetByClientId request, CancellationToken cancellationToken)
        {

            var result = new OperationResult<List<IdentityUser>>();
            try
            {

                var users = await _identityUser.Where(x => x.RecordStatus != RecordStatus.Deleted, "IdentityUserRoles", "IdentityUserRoles.Role", "IdentityUserRoles.Role.RoleClaims", "IdentityUserRoles.Role.RoleClaims.ClientClaim")
                    .Where(c => c.IdentityUserRoles.Select(c => c.Role.ClientId).Contains(request.ClientId)).ToListAsync();
              
                if (users.Count == 0)
                {
                    result.AddError(ErrorCode.NotFound, "No User data!");
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
