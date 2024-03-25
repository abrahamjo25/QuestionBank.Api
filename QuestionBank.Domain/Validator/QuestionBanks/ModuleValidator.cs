using FluentValidation;
using QuestionBank.Domain.Models.QuestionBanks;

namespace QuestionBank.Domain.Validator.QuestionBanks
{
    public class ModuleValidator : AbstractValidator<Module>
    {
        public ModuleValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("Name  can't be null")
                .NotEmpty().WithMessage("Name  can't be empty");
            RuleFor(x => x.Description)
                .NotNull().WithMessage("Description  can't be null")
                .NotEmpty().WithMessage("Description  can't be empty");
        }
    }
}
