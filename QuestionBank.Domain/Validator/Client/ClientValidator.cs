using FluentValidation;
using QuestionBank.Domain.Models;

namespace QuestionBank.Domain.Validator.Clients
{
    public class ClientValidator :AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(x => x.ClientName)
                .NotNull().WithMessage("Client name  can't be null")
                .NotEmpty().WithMessage("Client name  can't be empty");
            RuleFor(x => x.ClientId)
               .NotNull().WithMessage("Client id   can't be null")
                  .NotEmpty().WithMessage("Client id  can't be empty");
            RuleFor(x => x.ClientSecret)
              .NotNull().WithMessage("Client secret  can't be null")
              .NotEmpty().WithMessage("Client secret  can't be empty");

            RuleFor(x => x.Description)
              .NotNull().WithMessage("Client description  can't be null")
              .NotEmpty().WithMessage("Client description  can't be empty");

            RuleFor(x => x.AccessTokenLifeTime)
                .GreaterThan(3599).WithMessage("Access token lifetime should be greater than or equal to 3600")
                .NotNull().WithMessage("Access token lifetime   can't be null");

            RuleFor(x => x.RefreshTokenLifeTime)
            .GreaterThan(3599).WithMessage("Refresh token lifetime should be greater than or equal to 3600")
              .NotNull().WithMessage("Refresh token lifetime   can't be null");
        }
    }
}
