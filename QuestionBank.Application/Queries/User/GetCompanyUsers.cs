using QuestionBank.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;
using Microsoft.EntityFrameworkCore;
namespace QuestionBank.Application.Queries.Users
{
    public class GetCompanyUsers : IRequest<OperationResult<List<IdentityUser>>>
    {
        public RecordStatus? RecordStatus { get; set; }
    }

    internal class GetCompanyUsersHandler : IRequestHandler<GetCompanyUsers, OperationResult<List<IdentityUser>>>
    {
        private readonly IRepositoryBase<Role> _role;
        private readonly IRepositoryBase<IdentityUserRole> _identityUserRole;

        public GetCompanyUsersHandler(IRepositoryBase<Role> role, IRepositoryBase<IdentityUserRole> identityUserRole)
        {
            _role = role;
            _identityUserRole = identityUserRole;
        }
        public async Task<OperationResult<List<IdentityUser>>> Handle(GetCompanyUsers request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<List<IdentityUser>>();
            var companyRole = _role.FirstOrDefault(x => x.Name == "DefaultCompanyUser");
            //var companyRole = _context.Role.Where(x => x.Name == "company").FirstOrDefault();
            if (companyRole is null)
            {
                result.AddError(ErrorCode.NotFound, "No Copmany Role Found!");
                return result;
            }

            #region Assign Copmany
            // assign  Copmany users
            //var identityUserRoles = await _context.IdentityUserRole.Select(s => s.UserId).ToListAsync();

            //var usersWithNoRole = await _context.IdentityUser.Where(u => !identityUserRoles.Contains(u.Id)).ToListAsync();

            //if (usersWithNoRole.Count > 0)
            //{
            //    foreach (var user in usersWithNoRole)
            //    {
            //        var addNewUserRole = new IdentityUserRole() { UserId = user.Id, RoleId = companyRole.Id };
            //        _context.Add(addNewUserRole);
            //    }

            //    await _context.SaveChangesAsync();
            //}

            #endregion


            var users = await _identityUserRole.Where(u => u.RoleId == companyRole.Id && u.RecordStatus != RecordStatus.Deleted, "User")
                .Select(i => i.User).ToListAsync();

            if (request.RecordStatus == RecordStatus.Active)
                users = users.Where(u => u.RecordStatus == RecordStatus.Active).ToList();
            else if (request.RecordStatus == RecordStatus.InActive)
                users = users.Where(u => u.RecordStatus == RecordStatus.InActive).ToList();

            if (users.Count == 0)
            {
                result.AddError(ErrorCode.NotFound, "No User Data!");
                return result;
            }
            result.Payload = users;
            return result;

        }
    }
}
