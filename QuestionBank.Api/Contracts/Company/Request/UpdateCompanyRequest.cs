using System.ComponentModel.DataAnnotations;

namespace QuestionBank.Api.Contracts.Company.Request
{
    public class UpdateCompanyRequest
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string CompanyEmail { get; set; }
    }
}
