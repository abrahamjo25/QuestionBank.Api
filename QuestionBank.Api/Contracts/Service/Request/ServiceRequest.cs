using QuestionBank.Api.Contracts.Client.Request;
using System.ComponentModel.DataAnnotations;

namespace QuestionBank.Api.Contracts.Service.Request
{
    public class ServiceRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        
        public string ApiClaims { get; set; } = string.Empty;
    }
}
