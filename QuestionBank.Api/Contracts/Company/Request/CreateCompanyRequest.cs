using System.ComponentModel.DataAnnotations;

namespace QuestionBank.Api.Contracts.Company.Request
{
    public class CreateCompanyRequest
    {
        [Required]
        public string CompanyCode { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string CompanyEmail { get; set; }
    }
}
