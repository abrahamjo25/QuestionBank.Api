namespace QuestionBank.Api;
public class ForgotPasswordRequest
{
    public string UserName { get; set; }
    public string Token { get; set; }
    public string Password { get; set; }
}

