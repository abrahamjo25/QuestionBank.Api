using FluentValidation;
using QuestionBank.Domain.Models;

namespace QuestionBank.Domain.Validator.Clients
{
    public class ClientApiResourceValidator :AbstractValidator<ClientApiResources>
    {
        public ClientApiResourceValidator()
        {
            RuleFor(x => x.ClientId)
             .NotNull().WithMessage("Client id   can't be null");
            RuleFor(x => x.ApiClaimId)
            .NotNull().WithMessage("Api Claim id   can't be null");
        }
    }
}
