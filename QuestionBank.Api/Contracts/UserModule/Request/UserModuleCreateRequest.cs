namespace QuestionBank.Api.Contracts.UserModule.Request
{
    public class UserModuleCreateRequest
    {
        public string Username { get; set; }
        public long ModuleId { get; set; }
    }
}
