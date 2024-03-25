using QuestionBank.Domain.Models.Shared;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace QuestionBank.Api.Contracts.User.Request
{
    public class UserRequest
    {

        [Required]
        [MinLength(3)]
        public string Username { get; set; }
        [Required]
        [MinLength(3)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(3)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(3)]
        public string LastName { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        public string CompanyCode { get; set; }
        public bool IsSuperAdmin { get; set; } = false;
        public bool IsCompany { get; set; } = false;
        public bool IsAccountLocked { get; set; }=false;
        [Phone]
        public string PhoneNumber { get; set; }   
        public RecordStatus RecordStatus { get; set; }
        public List<long>? Roles { get; set; }
        public UserRequest()
        {
            Roles= new List<long>();
        }
    }
}
