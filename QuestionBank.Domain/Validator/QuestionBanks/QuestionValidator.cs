using FluentValidation;
using QuestionBank.Domain.Models.QuestionBanks;

namespace QuestionBank.Domain.Validator.QuestionBanks
{
    public class QuestionValidator : AbstractValidator<Question>
    {
        public QuestionValidator()
        {
            RuleFor(x => x.Text)
                .NotNull().WithMessage("Text  can't be null")
                .NotEmpty().WithMessage("Text  can't be empty");
            RuleFor(x => x.Explanation)
                .NotNull().WithMessage("Explanation  can't be null")
                .NotEmpty().WithMessage("Explanation  can't be empty");
        }
    }
}
