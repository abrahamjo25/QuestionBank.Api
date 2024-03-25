using QuestionBank.Api.Contracts.Client.Response;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Api.Contracts.User.Response
{
    public class RoleDetail
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long ClientId { get; set; }   
        public string Description { get; set; }
        public List<RoleClaimDetail> RoleClaims { get; set; }
        public string? ClientName { get { return Client?.ClientName; } }
        public ClientDetail? Client { get; set; }
        public RecordStatus RecordStatus { get; set; }
    }
    public class RoleClaimDetail
    {
        public ClientClaimDetail ClientClaim { get; set; }
    }

}
