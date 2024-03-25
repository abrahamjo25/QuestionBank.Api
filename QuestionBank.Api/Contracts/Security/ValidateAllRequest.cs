using System.ComponentModel.DataAnnotations;

namespace Identity.Api.Contracts.Security
{
    public class ValidateAllRequest
    {
        [Required]
        public string AccessToken { get; set; } = string.Empty;
        public string IdToken { get; set; } = string.Empty;
        public string ApiResource { get; set; }=string.Empty;
        public string ClientResource { get; set; }= string.Empty;
        public long ServiceId { get; set; }
        public string OrganizationCode { get; set; }
        public bool IsMultiTenant { get; set; }
        public bool IsCompany { get; set; }
        public string CompanyCode { get; set; }
    }
}
