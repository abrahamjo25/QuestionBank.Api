using QuestionBank.Domain.Models.Shared;
using System.ComponentModel.DataAnnotations;

namespace QuestionBank.Api.Contracts.Subscription
{
    public class OrganizationCreateDto
    {
        [Required(ErrorMessage ="Name is mandatory")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is mandatory")]
        public string Description { get; set; }
        public string Logo { get; set; }
        [Required(ErrorMessage = "Subscription is mandatory")]
        public long SubscriptionId { get; set; }
    }
    public class OrganizationDetailDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public long SubscriptionId { get; set; }
        public RecordStatus RecordStatus { get; set; }
    }
}
