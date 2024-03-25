namespace QuestionBank.Api.Contracts.Security
{
    public class EmailTokenRequest
    {
        public string Email { get; set; }
        public string FullName { get; set; }
        public int TokenLifetime { get; set; }
    }
}
