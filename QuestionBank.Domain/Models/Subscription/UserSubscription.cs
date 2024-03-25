using Identity.Domain.Validator;
using QuestionBank.Domain.Models.Shared;
using QuestionBank.Domain.Validator;
namespace QuestionBank.Domain.Models;
public class UserSubscription : BaseEntity
{
    public long UserId { get; set; }
    public long ClientId { get; set; }
    public long OrganizatoinId { get; set; }
    public bool IsDefault { get; set; }
    //
    public virtual IdentityUser User { get; set; }
    public virtual Client Client { get; set; }
    public virtual Organization Organizatoin { get; set; }

    public static UserSubscription Create(long userId, long clientId, long organizationId, bool isDefault)
    {
        var userSubscription = new UserSubscription { UserId = userId, ClientId = clientId, OrganizatoinId = organizationId, IsDefault = isDefault };
        // 
        var validator = new UserSubscriptionValidator();
        var response = validator.Validate(userSubscription);
        if (response.IsValid) return userSubscription;// valid
        var exception = new NotValidException("User Subscrption is not valid");
        response.Errors.ForEach(vr => exception.ValidationErrors.Add(vr.ErrorMessage));
        throw exception;
    }
}
