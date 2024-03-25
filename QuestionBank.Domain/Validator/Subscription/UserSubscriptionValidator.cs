using FluentValidation;
using QuestionBank.Domain.Models;

namespace Identity.Domain.Validator
{
    public class UserSubscriptionValidator : AbstractValidator<UserSubscription>
    {
        public UserSubscriptionValidator()
        {
            RuleFor(x => x.UserId).GreaterThan(0).WithMessage("User Id cannot be zero or negative");
            RuleFor(x => x.ClientId).GreaterThan(0).WithMessage("User Id cannot be zero or negative");
        }
    }
}
