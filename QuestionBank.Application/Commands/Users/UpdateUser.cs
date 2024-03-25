using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;

namespace QuestionBank.Application.Commands.Users
{
    public class UpdateUser : IRequest<OperationResult<IdentityUser>>
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsSuperAdmin { get; set; } = false;
        public string PhoneNumber { get; set; }
        public string CompanyCode { get; set; }
        public bool IsCompany { get; set; } = false;
        public List<long> Roles { get; set; }
    }
    internal class UpdateUserCommandHandler : IRequestHandler<UpdateUser, OperationResult<IdentityUser>>
    {
        private readonly IRepositoryBase<IdentityUser> _identityUser;
        private readonly IPassword _passwordService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public UpdateUserCommandHandler(IRepositoryBase<IdentityUser> identityUser, IPassword password, IHttpContextAccessor httpContextAccessor)
        {
            _identityUser = identityUser;
            _passwordService = password;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<IdentityUser>> Handle(UpdateUser request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<IdentityUser>();

            var userAccount = await _identityUser.FirstOrDefaultAsync(x => x.Id == request.Id, "IdentityUserRoles");
            if (userAccount is null)
            {
                result.AddError(ErrorCode.IdentityUserDoesNotExist, "Account Does not Exist");
                return result;
            }
            userAccount.IdentityUserRoles.Clear();
            userAccount.UpdateUser(request.FirstName, request.LastName, request.Email, request.IsSuperAdmin, request.PhoneNumber, request.CompanyCode, request.IsCompany);
            request.Roles.ForEach(x =>
            {
                userAccount.AddRole(new IdentityUserRole
                {
                    UserId = userAccount.Id,
                    RoleId = x
                });
            });
            userAccount.UpdateAudit(_session.GetString("user"));
            _identityUser.Update(userAccount);

            result.Payload = userAccount;
            result.Message = "Operation success";

            return result;
        }
    }
}