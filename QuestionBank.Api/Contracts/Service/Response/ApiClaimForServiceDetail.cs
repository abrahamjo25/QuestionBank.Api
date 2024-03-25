using QuestionBank.Api.Contracts.Client.Response;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Api.Contracts.Service.Response
{
    public class ApiClaimForServiceDetail
    {
        public long Id { get; set; }
        public string Claim { get; set; }
        public bool RequireIdToken { get; set; }
        public RecordStatus RecordStatus { get; set; }
    }
}
