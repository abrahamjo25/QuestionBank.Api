using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Api.Contracts.Client.Response
{
    public class ClientDetails
    {
        public long Id { get; set; }
        public string ClientName { get; set; } = string.Empty;
        public string ClientId { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int AccessTokenLifeTime { get; set; }
        public int RefreshTokenLifeTime { get; set; }
        public List<ClientApiDetail> ClientApiResourses { get; set; }
        public RecordStatus RecordStatus { get; set; }

    }
    public class ClientApiDetail
    {
        public ApiClaimDetail ApiClaim { get; set; }
    }

}
