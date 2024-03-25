using FluentValidation;
using QuestionBank.Domain.Models.QuestionBanks;

namespace QuestionBank.Domain.Validator.QuestionBanks
{
    public class UserModuleValidator : AbstractValidator<UserModule>
    {
        public UserModuleValidator()
        {
            RuleFor(x => x.Username)
                 .NotNull().WithMessage("User Id  can't be null")
                 .NotEmpty().WithMessage("User Id  can't be empty");
            RuleFor(x => x.ModuleId)
                .NotNull().WithMessage("Module can't be null")
                .NotEmpty().WithMessage("Module  can't be empty");
        }
    }
}
