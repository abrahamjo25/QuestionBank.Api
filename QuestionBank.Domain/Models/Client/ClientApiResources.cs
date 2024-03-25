using QuestionBank.Domain.Models.Shared;
using QuestionBank.Domain.Validator.Clients;

namespace QuestionBank.Domain.Models
{
    public class ClientApiResources : BaseEntity
    {
        
        public long ClientId { get; private set; }
        public long ApiClaimId { get; private set; }
        public virtual Client Client { get;  set; }
        public virtual ApiClaim ApiClaim { get;  set; }

        public static ClientApiResources Create (long clientId, long apiClaimId, long id=0,bool isReadonly=false)
        {
            var validator = new ClientApiResourceValidator();
            var clientApiResources = new ClientApiResources
            {
                Id = id,
                ClientId = clientId,
                ApiClaimId = apiClaimId,
                IsReadOnly= isReadonly,
            };
            var validationResult = validator.Validate (clientApiResources);
            if (validationResult.IsValid) return clientApiResources;
            var exception = new NotValidException("Client api Resource is not valid");
            validationResult.Errors.ForEach(vr => exception.ValidationErrors.Add(vr.ErrorMessage));
            throw exception;
        }
    }
}
