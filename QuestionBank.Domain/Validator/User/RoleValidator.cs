using FluentValidation;
using QuestionBank.Domain.Models;

namespace QuestionBank.Domain.Validator.User
{
    public class RoleValidator : AbstractValidator<Role>
    {
        public RoleValidator()
        {
            RuleFor(x => x.Name)
                  .NotNull().WithMessage("Name  can't be null")
                  .NotEmpty().WithMessage("Name  can't be empty");           
            RuleFor(x => x.Description)
                .NotNull().WithMessage("Description  can't be null")
                .NotEmpty().WithMessage("Description  can't be empty");
            RuleFor(x => x.ClientId)
                .NotNull().WithMessage("Client id   can't be null");
        }
    }
}
