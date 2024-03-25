using QuestionBank.Domain.Models.Shared;
namespace QuestionBank.Api.Contracts.Service.Request
{
    public class ActivateDeactivateServiceRequest
    {
        public long ServiceId { get; set; }
        public RecordStatus Status { get; set; }
    }
}
