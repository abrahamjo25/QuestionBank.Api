using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Api.Contracts.Service.Response
{
    public class ServiceDetailDto
    {
        public long Id { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; }
        public RecordStatus RecordStatus { get; set; }
        public List<ApiClaimForServiceDetail> ServiceClaims { get; set; }
    }
}
