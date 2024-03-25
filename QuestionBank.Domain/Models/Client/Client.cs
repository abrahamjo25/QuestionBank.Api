using QuestionBank.Domain.Models.Shared;
using QuestionBank.Domain.Validator.Clients;

namespace QuestionBank.Domain.Models
{
    public class Client:BaseEntity
    {
        private List<ClientApiResources> _clientApiResources = new List<ClientApiResources>();
        public string ClientName { get; private set; } = string.Empty;
        public string ClientId { get;private set; } = string.Empty;
        public string ClientSecret { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public int AccessTokenLifeTime { get; private set; }
        public int RefreshTokenLifeTime { get;private set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpireDate { get; set; }
        public ICollection<ClientApiResources> ClientApiResources { get { return _clientApiResources; } }
        public virtual List<Role>? Role { get; private set; }
        //factory
        public static Client CreatClient (string clientName,string clientId,string clientSecret,string description,int accestokenLifetime,int refreshtokenLifetime, long id=0,bool isreadonly=false)
        {
            var validator = new ClientValidator();
            var client =  new Client
            {
                Id = id,
                ClientName = clientName,
                ClientId = clientId,
                ClientSecret = clientSecret,
                Description = description,
                AccessTokenLifeTime = accestokenLifetime,
                RefreshTokenLifeTime = refreshtokenLifetime,
                RegisteredDate = DateTime.UtcNow,
                RefreshToken = "",
                IsReadOnly= isreadonly
                
            };
            var validationResult = validator.Validate(client);
            if (validationResult.IsValid) return client;
            var exception = new NotValidException("Client is not valid");
            validationResult.Errors.ForEach(vr => exception.ValidationErrors.Add(vr.ErrorMessage));
            throw exception;
        }
        public void UpdateClient(string clientName,string clientId,string description,int accestokenLifetime,int refreshtokenLifetime)
        {
            ClientName= clientName;
            ClientId= clientId;
            Description= description;
            AccessTokenLifeTime= accestokenLifetime;
            RefreshTokenLifeTime= refreshtokenLifetime;
            LastUpdateDate = DateTime.Now;
        }
        public void UpdateStatus(RecordStatus status)
        {
            RecordStatus = status;
        }
        public void UpdateSecret (string newSecret)
        {
            ClientSecret = newSecret;
        }
        public void AddApiResource(ClientApiResources apiClaims)
        {
            _clientApiResources.Add(apiClaims);
        }

        public void RemoveApiResource(ClientApiResources apiClaims)
        {
            _clientApiResources.Remove(apiClaims);
        }
    }
}
