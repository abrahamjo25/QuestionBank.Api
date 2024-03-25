using FluentValidation;
using QuestionBank.Domain.Models;

namespace QuestionBank.Domain.Validator
{
    internal class OrgnaizationValidator : AbstractValidator<Organization>
    {
        public OrgnaizationValidator()
        {

            RuleFor(x => x.Name)
                .NotNull().WithMessage("Name  can't be null")
                .NotEmpty().WithMessage("Name  can't be empty");
            RuleFor(x => x.Description)
                .NotNull().WithMessage("Description  can't be null")
                .NotEmpty().WithMessage("Description  can't be empty");
            RuleFor(x => x.Logo)
                .NotNull().WithMessage("Logo can't be null");
            RuleFor(x => x.SubscriptionId)
                .NotNull().WithMessage("SubscriptionId can't be null.")
                .LessThan(1).WithMessage("subscription Id can't be lessthan or equal to zero");
        }
    }
}
