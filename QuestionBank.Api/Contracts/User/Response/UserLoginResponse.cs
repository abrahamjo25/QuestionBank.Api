namespace QuestionBank.Api.Contracts.User.Response
{
    public class UserLoginResponse
    {
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string IdToken { get; set; }
        public string RefreshToken { get; set; }
        public List<RoleResponse> Roles { get; set; }

    }

    public class RoleResponse
    {
        public RoleResponse()
        {
            Claims = new List<ClientClaimResponse>();
        }
        public string RoleName { get; set; }
        public List<ClientClaimResponse> Claims { get; set; }
    }

    public class ClientClaimResponse
    {
        public long Id { get; set; }
        public string Claim { get; set; }
    }
}

