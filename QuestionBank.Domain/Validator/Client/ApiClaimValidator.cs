using FluentValidation;

namespace QuestionBank.Domain.Validator.Clients
{
    public class ApiClaimValidator :AbstractValidator<ApiClaim>
    {
        public ApiClaimValidator()
        {
            RuleFor(x => x.Claim)
                  .NotNull().WithMessage("Claim  can't be null")
                  .NotEmpty().WithMessage("Claim  can't be empty");
           
            RuleFor(x => x.ServiceId)
                .NotNull().WithMessage("Service id   can't be null");
        }
    }
}
