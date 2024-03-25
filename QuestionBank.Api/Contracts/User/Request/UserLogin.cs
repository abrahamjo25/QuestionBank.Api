using System.ComponentModel.DataAnnotations;

namespace QuestionBank.Api.Contracts.User.Request
{
    public class UserLogin 
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
