using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Domain.Models
{
    public class Service : BaseEntity
    {
        public string Name { get; private set; } 
        public string Description { get; private set; }
        public bool IsMultiTenant { get; set; }
        public ICollection<ApiClaim> ApiClaims { get; set; }
        public static Service Create( string name, string description,long id=0,bool isreadonly=false)
        {
            return new Service
            {
                Name = name,
                Description = description,
                Id = id,
                RecordStatus = RecordStatus.Active,
                IsReadOnly=isreadonly
            };
        }

        public void UpdateService(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
        public void UpdateStatus(RecordStatus status)
        {
            RecordStatus = status;
        }
    }
}
