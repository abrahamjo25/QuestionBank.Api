using QuestionBank.Domain.Models.Shared;
using QuestionBank.Domain.Models.User;
using QuestionBank.Domain.Validator.User;

namespace QuestionBank.Domain.Models
{
    public class Role : BaseEntity
    {
        private  List<RoleClaim> _roleCalims = new List<RoleClaim>();
        public string Name { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public long ClientId { get; private set; }
        public virtual Client Client { get; private set; }
        public ICollection<RoleClaim> RoleClaims { get { return _roleCalims; } }
        public static Role Create(string name, string description , long clientId, long  id=0,bool isreadonly=false)
        {
            var validator = new RoleValidator();
            var clientClaim = new Role
            {
                Id = id,
                Name = name,
                Description = description,
                ClientId = clientId,
                RecordStatus = RecordStatus.Active,
                IsReadOnly= isreadonly
            };
            var validationResult = validator.Validate(clientClaim);
            if (validationResult.IsValid) return clientClaim;
            var exception = new NotValidException("Post is not valid");
            validationResult.Errors.ForEach(vr => exception.ValidationErrors.Add(vr.ErrorMessage));
            throw exception;
        }
        public void AddRoleClaim(RoleClaim roleClaim)
        {
            _roleCalims.Add(roleClaim);
        }

        public void Update(string name, string description, long clientId)
        {
            Name=name;
            Description=description;
            ClientId=clientId;
        }

        public void UpdateStatus(RecordStatus status)
        {
            RecordStatus=status;
        }
    }
}
