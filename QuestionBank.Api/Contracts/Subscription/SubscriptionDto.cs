using QuestionBank.Domain.Models.Shared;
using System.ComponentModel.DataAnnotations;

namespace QuestionBank.Api.Contracts.Subscription
{
    public class SubscriptionDto
    {
        [Required(ErrorMessage = "Name is mandatory")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is mandatory")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Code is mandatory")]
        public string Code { get; set; }
    }
    public class SubscriptionDetailDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public RecordStatus RecordStatus { get; set; }
    }
}
