using QuestionBank.Domain.Models.Shared;
using QuestionBank.Domain.Validator.Clients;

namespace QuestionBank.Domain.Models.Clients
{
    public class ApiClaim : BaseEntity
    {
        public string Claim { get; private set; }
        public bool RequireIdToken { get; private set; } = true;
        public long ServiceId { get; private set; }
        public Service Service { get; private set; }

        public static ApiClaim Create(string claim, long serviceId, bool requireIdToken = true, long id=0,bool isreadonly=false)
        {
            var validator = new ApiClaimValidator();
            var apiClaim = new ApiClaim
            {
                Id=id,
                Claim = claim,
                ServiceId = serviceId,
                RequireIdToken = requireIdToken,
                RecordStatus=RecordStatus.Active,
                IsReadOnly=isreadonly
            };

            var response = validator.Validate(apiClaim);
            if (response.IsValid) return apiClaim;
            var exception = new NotValidException("  is not valid");
            response.Errors.ForEach(vr => exception.ValidationErrors.Add(vr.ErrorMessage));
            throw exception;
        }
        public void Update(string claim, long serviceId,bool requiredtoken)
        {
            Claim = claim;
            ServiceId = serviceId;
            RequireIdToken= requiredtoken;
        }

        public void UpdateStatus(RecordStatus status)
        {
            RecordStatus = status;
        }
    }
}
