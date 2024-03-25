using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Api.Contracts.User.Response
{
    public class UserDetail
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; } 
        public string FirstName { get; set; }
        public RecordStatus RecordStatus { get; set; }

        public string LastName { get; set; }
        public bool IsSuperAdmin { get; set; }
        public bool IsAccountLocked { get; set; }
        public string PhoneNumber { get; set; } 
        public string VerificationToken { get; set; } 
        public int LoginAttemptCount { get; set; }
        public DateTime LastLoginDateTime { get; set; }
        public bool IsConfirmationEmailSent { get; set; }
        public List<UserRoleDetail>? Roles { get; set; }
    }

    public class UserRoleDetail
    {
        public RoleDetail Role { get; set; }
    }

}
