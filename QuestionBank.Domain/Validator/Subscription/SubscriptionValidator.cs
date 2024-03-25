using FluentValidation;
using QuestionBank.Domain.Models;

namespace QuestionBank.Domain.Validator;
internal class SubscriptionValidator : AbstractValidator<Subscription>
{
    public SubscriptionValidator()
    {
        RuleFor(x => x.Name)
            .NotNull().WithMessage("Name  can't be null")
            .NotEmpty().WithMessage("Name  can't be empty");
        RuleFor(x => x.Description)
            .NotNull().WithMessage("Description  can't be null")
            .NotEmpty().WithMessage("Description  can't be empty");
        RuleFor(x => x.Code)
            .NotNull().WithMessage("Code can't be null");
    }
}
