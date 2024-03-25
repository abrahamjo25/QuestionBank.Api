using QuestionBank.Domain.Models.Shared;
using QuestionBank.Domain.Validator.User;

namespace QuestionBank.Domain.Models.User
{
    public class ClientClaim : BaseEntity
    {
        public string Name { get; private set; } = string.Empty;
        public string Claim { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;

        public long ClientId { get; private set; }
        public virtual Client Client { get; private set; }

        //factory
        public static ClientClaim Create(string name, string claim, string descripton, long clientId, long id=0,bool isreadonly=false)
        {
            var validator = new ClientClaimValidator();
            var clientClaim = new ClientClaim
            {
                Id = id,
                Name = name,
                Claim = claim,
                Description = descripton,
                ClientId = clientId,
                IsReadOnly= isreadonly
            };
            var validationResult = validator.Validate(clientClaim);
            if (validationResult.IsValid) return clientClaim;
            var exception = new NotValidException("Post is not valid");
            validationResult.Errors.ForEach(vr => exception.ValidationErrors.Add(vr.ErrorMessage));
            throw exception;
        }

        public void Update(string name, string claim, string description , long clientId)
        {
            Name = name;
            Claim = claim;
            ClientId = clientId;
            Description = description;
        }

        public void UpdateStatus(RecordStatus status)
        {
            RecordStatus = status;
        }
    }
}
