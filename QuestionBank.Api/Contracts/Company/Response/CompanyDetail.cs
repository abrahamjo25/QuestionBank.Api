using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Api.Contracts.Company.Response
{
    public class CompanyDetail
    {
        public long Id { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyEmail { get; set; }
        public RecordStatus RecordStatus { get; set; }
    }
}
