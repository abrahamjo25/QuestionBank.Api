using FluentValidation;
using QuestionBank.Domain.Models.QuestionBanks;

namespace QuestionBank.Domain.Validator.QuestionBanks
{
    public class CourseValidator : AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(x => x.CourseName)
                  .NotNull().WithMessage("Name  can't be null")
                  .NotEmpty().WithMessage("Name  can't be empty");
            RuleFor(x => x.Description)
                .NotNull().WithMessage("Description  can't be null")
                .NotEmpty().WithMessage("Description  can't be empty");
        }
    }
}
