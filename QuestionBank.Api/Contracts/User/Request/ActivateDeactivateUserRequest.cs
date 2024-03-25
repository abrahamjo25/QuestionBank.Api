public class ActivateDeactivateUserRequest
{
    public QuestionBank.Api.Contracts.Common.UserStatusAction StatusAction { get; set; }
    public long UserId { get; set; }
}
