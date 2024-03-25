using QuestionBank.Domain.Models.Shared;
using System.ComponentModel.DataAnnotations;

namespace QuestionBank.Api.Contracts.User.Request
{
    public class ClientClaimRequest
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        [MinLength(3)]
        public string Claim { get; set; }
        [Required]
        [MinLength(3)]
        public string Description { get;  set; }
        [Required]
        public long ClientId { get;  set; }
    }

    public class UpdateClientClaimStatusDto
    {
        public RecordStatus RecordStatus { get; set; }
        public long Id { get; set; }
    }

}
