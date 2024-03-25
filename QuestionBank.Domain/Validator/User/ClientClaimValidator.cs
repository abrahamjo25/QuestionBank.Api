using FluentValidation;
using QuestionBank.Domain.Models.User;

namespace QuestionBank.Domain.Validator.User
{
    public class ClientClaimValidator : AbstractValidator<ClientClaim>
    {
        public ClientClaimValidator()
        {
            RuleFor(x => x.Name)
                  .NotNull().WithMessage("Name  can't be null")
                  .NotEmpty().WithMessage("Name  can't be empty");
            RuleFor(x => x.Claim)
                 .NotNull().WithMessage("Claim  can't be null")
                 .NotEmpty().WithMessage("Claim  can't be empty");
            RuleFor(x => x.Description)
                .NotNull().WithMessage("Description  can't be null")
                .NotEmpty().WithMessage("Description  can't be empty");
            RuleFor(x => x.ClientId)
                .NotNull().WithMessage("Client id   can't be null");
        }
    }
}
