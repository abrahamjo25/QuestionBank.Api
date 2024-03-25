using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Api.Contracts.Client.Request
{
    public class ActivateDeactivateClientRequest
    {
        public string ClientId { get; set; }
        public RecordStatus Status { get; set; }
    }
}
