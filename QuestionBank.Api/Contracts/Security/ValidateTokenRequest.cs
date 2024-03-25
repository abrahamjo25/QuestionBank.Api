namespace Identity.Api.Contracts.Security
{
    public class ValidateTokenRequest
    {
        public string AccessToken { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
