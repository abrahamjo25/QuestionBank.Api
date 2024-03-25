using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionBank.Application.Helpers.Common;
using MediatR;
using QuestionBank.Domain.Models;
using QuestionBank.Infrastructure.Context;
namespace QuestionBank.Application.Queries.Users
{
    public class GetUserById : IRequest<OperationResult<IdentityUser>>
    {
        public long Id { get; set; }
    }
    internal class GetUserByIdQueryHandler : IRequestHandler<GetUserById, OperationResult<IdentityUser>>
    {
        private readonly ApplicationDbContext _context;
        private readonly IRepositoryBase<IdentityUser> _identityUser;

        public GetUserByIdQueryHandler(IRepositoryBase<IdentityUser> identityUser)
        {
            _identityUser = identityUser;
        }

        public async Task<OperationResult<IdentityUser>> Handle(GetUserById request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<IdentityUser>();
            try
            {
                var user = await _identityUser.FirstOrDefaultAsync(x => x.Id == request.Id, "IdentityUserRoles", "IdentityUserRoles.Role", "IdentityUserRoles.Role.RoleClaims", "IdentityUserRoles.Role.RoleClaims.ClientClaim");
                if (user is null)
                {
                    result.AddError(ErrorCode.NotFound, "User is not found!");
                    return result;
                }
                result.Payload = user;
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
