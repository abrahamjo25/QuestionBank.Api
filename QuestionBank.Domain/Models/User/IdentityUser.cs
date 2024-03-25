using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Domain.Models
{
    public class IdentityUser : BaseEntity
    {
        private List<IdentityUserRole> _roles = new List<IdentityUserRole>();
        public string Username { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string FirstName { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public string Password { get; private set; } = string.Empty;
        public bool IsSuperAdmin { get; private set; }
        public bool IsAccountLocked { get; private set; }
        public string PhoneNumber { get; private set; } = string.Empty;
        public string VerificationToken { get; private set; } = string.Empty;
        public int LoginAttemptCount { get; private set; }
        public DateTime LastLoginDateTime { get; private set; }
        public bool IsConfirmationEmailSent { get; private set; }
        public bool IsCompany { get; private set; }
        public string CompanyCode { get; private set; } = string.Empty;
        public int IdTokenLifetime { get; private set; } = 7_200;
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime RefreshTokenExpireDate { get; set; }
        public ICollection<IdentityUserRole> IdentityUserRoles { get { return _roles; } }

        //validation
        //erro handling 
        //notification strategies

        public static IdentityUser CreateUser(
            string userName,
            string email,
            string firstName,
            string lastName,
            string password,
            bool isSuperAdmin,
            bool isAccountLocked,
            string phoneNumber,
            //bool isreadonly = false,
            long id = 0
            )
        {
            return new IdentityUser
            {
                Id = id,
                Username = userName,
                Email = email,
                FirstName = firstName,
                LastName = lastName,
                Password = password,
                IsSuperAdmin = isSuperAdmin,
                IsAccountLocked = isAccountLocked,
                PhoneNumber = phoneNumber,
                RefreshToken = "",
                RecordStatus = RecordStatus.Active,
                //IsReadOnly = isreadonly,
            };
        }
        public static IdentityUser ForCompany
            (string userName,
            string email,
            string firstName,
            string lastName,
            string password,
            bool isSuperAdmin,
            bool isAccountLocked,
            string phoneNumber,
            string CompanyCode,
            bool isreadonly = false,
            bool IsCompany = true,
            long id = 0
            )
        {
            return new IdentityUser
            {
                Id = id,
                Username = userName,
                Email = email,
                FirstName = firstName,
                LastName = lastName,
                Password = password,
                IsSuperAdmin = isSuperAdmin,
                IsAccountLocked = isAccountLocked,
                PhoneNumber = phoneNumber,
                RefreshToken = "",
                RecordStatus = RecordStatus.Active,
                IsReadOnly = isreadonly,
                CompanyCode = CompanyCode,
                IsCompany = IsCompany,
            };
        }
        public void UpdateUser(
            string firstName,
            string lastName,
            string email,
            bool isSuperAdmin,
            string phoneNumber,
            string companyCode,
            bool IsCompany)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.IsSuperAdmin = isSuperAdmin;
            this.Email = email;
            this.IsCompany = IsCompany;
            this.CompanyCode = CompanyCode;
        }
        public void UpdatePassword(string passsword)
        {
            Password = passsword;
        }
        public void ActivateDeactivate(UserStatusAction userStatusAction)
        {
            IsAccountLocked = userStatusAction == UserStatusAction.MarkAsInActive ? true : false;
        }

        public void AddRole(IdentityUserRole role)
        {
            _roles.Add(role);
        }
        public void UpdateStatus(RecordStatus status)
        {
            RecordStatus = status;
        }
        public void DeleteUser()
        {
            this.RecordStatus = RecordStatus.Deleted;
        }
    }
}
