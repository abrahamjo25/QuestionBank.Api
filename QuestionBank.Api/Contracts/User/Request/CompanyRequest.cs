using QuestionBank.Domain.Models.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace QuestionBank.Api.Contracts.User.Request
{
    public class CompanyRequest
    {
        [Required, MinLength(3)]
        public string Username { get; set; }
        [Required]
        [MinLength(3)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(3)]
        public string CompanyCode { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        public bool IsSuperAdmin { get; set; } = false;
        public bool IsCompany { get; set; } = true;
        public bool IsAccountLocked { get; set; } = false;
        [Phone]
        public string PhoneNumber { get; set; }
        public RecordStatus RecordStatus { get; set; }
        public List<long>? Roles { get; set; }
        public CompanyRequest()
        {
            Roles = new List<long>();
        }
    }
}
