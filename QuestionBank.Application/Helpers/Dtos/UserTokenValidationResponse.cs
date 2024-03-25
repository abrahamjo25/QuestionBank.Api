namespace Identity.Application.Helpers.Dtos;
public class UserTokenValidationResponse
{
    public string ClientId { get; set; }
    public string UserId { get; set; }
    public string Tenant { get; set; }
    public bool IsCompany { get; set; }
    public string CompanyCode { get; set; }
}
