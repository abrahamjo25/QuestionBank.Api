using QuestionBank.Domain.Models.Shared;
using QuestionBank.Domain.Validator;

namespace QuestionBank.Domain.Models
{
    public class Subscription : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public virtual ICollection<Organization> Organizatoins { get; set; }

        public static Subscription Create(string name, string description, string code)
        {
            var subscription = new Subscription { Name = name, Description = description, Code = code };

            //validation
            var validator = new SubscriptionValidator();
            var response = validator.Validate(subscription);
            if (response.IsValid) return subscription;// valid
            var exception = new NotValidException("subscription is not valid");
            response.Errors.ForEach(vr => exception.ValidationErrors.Add(vr.ErrorMessage));
            throw exception;
        }
        public void Update(string name, string description, string code)
        {

            this.Name = name;
            this.Description = description;
            this.Code = Code;

            //validation
            var validator = new SubscriptionValidator();
            var response = validator.Validate(this);
            if (response.IsValid) return;//valid
            var exception = new NotValidException("subscription is not valid");
            response.Errors.ForEach(vr => exception.ValidationErrors.Add(vr.ErrorMessage));
            throw exception;
        }
    }
}
