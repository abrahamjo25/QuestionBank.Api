using System.ComponentModel.DataAnnotations;

namespace QuestionBank.Api.Contracts.Client.Request
{
    public class ClientClaimApiResourceRequest
    {
        [Required]
        public long ClientId { get; set; }

    }

}
