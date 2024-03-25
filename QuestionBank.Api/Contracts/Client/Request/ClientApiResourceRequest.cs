using System.ComponentModel.DataAnnotations;

namespace QuestionBank.Api.Contracts.Client.Request
{
    public class ClientApiResourceRequest
    {
        [Required]
        public long ClientId { get; set; }
        [Required]
        public List<long> ApiClaimId { get; set; }
    }
}
