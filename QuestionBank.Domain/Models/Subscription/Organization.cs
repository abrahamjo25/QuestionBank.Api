using QuestionBank.Domain.Models.Shared;
using QuestionBank.Domain.Validator;
namespace QuestionBank.Domain.Models;
public class Organization : BaseEntity
{
    public string Name { get; set; }
    public string OrganizationCode { get; set; }
    public string Description { get; set; }
    public string Logo { get; set; }
    public long SubscriptionId { get; set; }
    public virtual Subscription Subscription { get; set; }

    public static Organization Create(string name, string description, string logo, long subscriptionId)
    {
        var organization = new Organization { Name = name, Description = description, Logo = logo, SubscriptionId = subscriptionId };

        //validation
        var validator = new OrgnaizationValidator();
        var response = validator.Validate(organization);
        if (response.IsValid) return organization;// valid
        var exception = new NotValidException("Organization is not valid");
        response.Errors.ForEach(vr => exception.ValidationErrors.Add(vr.ErrorMessage));
        throw exception;
    }
    public void Update(string name, string description, string logo, long subscriptionId)
    {

        this.Name = name;
        this.Description = description;
        this.Logo = Logo;
        this.SubscriptionId = subscriptionId;

        //validation
        var validator = new OrgnaizationValidator();
        var response = validator.Validate(this);
        if (response.IsValid) return;//valid
        var exception = new NotValidException("Organization is not valid");
        response.Errors.ForEach(vr => exception.ValidationErrors.Add(vr.ErrorMessage));
        throw exception;
    }
}
