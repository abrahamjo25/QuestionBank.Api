using System.ComponentModel.DataAnnotations;

namespace QuestionBank.Api.Contracts.Client.Request
{
    public class ClientLogin
    {
        [Required]
        public string ClientId { get; set; }
        [Required]
        public string ClientSecret { get; set; }
    }
}
