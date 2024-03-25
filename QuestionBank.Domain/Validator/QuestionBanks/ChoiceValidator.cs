using FluentValidation;
using QuestionBank.Domain.Models.QuestionBanks;

namespace QuestionBank.Domain.Validator.QuestionBanks
{
    public class ChoiceValidator : AbstractValidator<Choice>
    {
        public ChoiceValidator()
        {
            RuleFor(x => x.Label)
                 .NotNull().WithMessage("Label  can't be null")
                 .NotEmpty().WithMessage("Label  can't be empty");
            RuleFor(x => x.Text)
                .NotNull().WithMessage("Text  can't be null")
                .NotEmpty().WithMessage("Text  can't be empty");
        }
    }
}
