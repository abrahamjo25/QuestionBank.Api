using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;

namespace QuestionBank.Application.Commands.Users
{
    public class CreateUser : IRequest<OperationResult<IdentityUser>>
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public bool IsSuperAdmin { get; set; } = false;
        public bool IsAccountLocked { get; set; } = false;
        //public bool IsCompany { get; set; } = false;
        public string PhoneNumber { get; set; }
        public string CompanyCode { get; set; }
        public List<long> Roles { get; set; }
        public CreateUser()
        {
            Roles = new List<long>();
        }
    }
    internal class CreateUserCommandHandler : IRequestHandler<CreateUser, OperationResult<IdentityUser>>
    {
        private readonly IRepositoryBase<IdentityUser> _identityUser;
        private readonly IRepositoryBase<Role> _role;
        private readonly IPassword _passwordService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public CreateUserCommandHandler(IRepositoryBase<IdentityUser> identityUser, IRepositoryBase<Role> role, IPassword password, IHttpContextAccessor httpContextAccessor)
        {
            _role = role;
            _passwordService = password;
            _identityUser = identityUser;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<IdentityUser>> Handle(CreateUser request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<IdentityUser>();
            try
            {
                if (request.Roles.Count == 0)
                {
                    result.AddError(ErrorCode.RecordExist, "Empty Role . ");
                    return result;
                }
                if (_identityUser.ExistWhere(x => x.Username == request.Username.ToUpper()))
                {
                    result.AddError(ErrorCode.RecordExist, "User already exist.");
                    return result;
                }
                if (_identityUser.ExistWhere(x => x.Email == request.Email.ToUpper()))
                {
                    result.AddError(ErrorCode.RecordExist, "Email already exist.");
                    return result;
                }
                //if (request.IsCompany == true)
                //{
                //    request.FirstName = "Company";
                //    request.LastName = "Company";
                //}
                //if (request.IsCompany == false && (request.CompanyCode == "" || request.CompanyCode == null))
                //{
                //    request.CompanyCode = "PVT";
                //}
                //var user = new IdentityUser();
                //if (request.IsCompany == true)
                //{
                //    user = IdentityUser.ForCompany(request.Username.ToUpper(), request.Email.ToUpper(), request.FirstName, request.LastName, request.Password, request.IsSuperAdmin, request.IsAccountLocked, request.PhoneNumber, request.CompanyCode, request.IsCompany);
                //}
                //else
                //{
                //}
                 var user = IdentityUser.CreateUser(request.Username.ToUpper(), request.Email.ToUpper(), request.FirstName, request.LastName, request.Password, request.IsSuperAdmin, request.IsAccountLocked, request.PhoneNumber);
                user.UpdatePassword(await _passwordService.HashPassword(request.Password));

                request.Roles.ForEach(roleid =>
                {
                    user.AddRole(new IdentityUserRole
                    {
                        RoleId = roleid,
                        UserId = user.Id
                    });

                });

                user.Register(_session.GetString("user"));
                _identityUser.Add(user);
                result.Payload = user;
                result.Message = "Operation success";
            }
            catch (Exception e)
            {
                result.AddError(ErrorCode.ServerError, e.Message);
            }


            return result;
        }
    }
}
