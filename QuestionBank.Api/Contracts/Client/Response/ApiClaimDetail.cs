using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Api.Contracts.Client.Response
{
    public class ApiClaimDetail
    {
        public long Id { get; set; }
        public string Claim { get; set; }
        public ServiceDetail Service { get; set; }
        public bool RequiredIdToken { get; set; }
        public RecordStatus RecordStatus { get; set; }
        public long ServiceId { get; set; }
    }

    
}
