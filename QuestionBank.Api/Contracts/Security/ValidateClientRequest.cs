using System.ComponentModel.DataAnnotations;

namespace Identity.Api.Contracts.Security
{
    public class ValidateClientRequest
    {
        [Required]
        public string AccessToken { get; set; }
        [Required]
        public string ApiResource { get; set; }
        [Required]
        public long ServiceId { get; set; }
    }
}
