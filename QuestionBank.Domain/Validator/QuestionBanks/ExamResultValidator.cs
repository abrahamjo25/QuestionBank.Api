using FluentValidation;
using QuestionBank.Domain.Models.QuestionBanks;

namespace QuestionBank.Domain.Validator.QuestionBanks
{
    public class ExamResultValidator : AbstractValidator<ExamResult>
    {
        public ExamResultValidator()
        {
            RuleFor(x => x.UserId)
                .NotNull().WithMessage("User  can't be null")
                .NotEmpty().WithMessage("User  can't be empty");
            RuleFor(x => x.UserModuleId)
                .NotNull().WithMessage("Module  can't be null")
                .NotEmpty().WithMessage("Module  can't be empty");
        }
    }
}
