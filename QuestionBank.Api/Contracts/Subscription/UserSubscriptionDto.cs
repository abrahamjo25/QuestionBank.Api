namespace QuestionBank.Api.Contracts.Subscription;
public class UserSubscriptionDto
{
    public long UserId { get; set; }
    public long ClientId { get; set; }
    public long OrganizatoinId { get; set; }
    public bool IsDefault { get; set; }

}
