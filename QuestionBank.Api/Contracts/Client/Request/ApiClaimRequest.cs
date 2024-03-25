using QuestionBank.Domain.Models.Shared;
using System.ComponentModel.DataAnnotations;

namespace QuestionBank.Api.Contracts.Client.Request
{
    public class ApiClaimRequest
    {
        [Required]
        public List<string> Claim { get; set; }
        [Required]
        public long ServiceId { get; set; }
        [Required]
        public bool RequiredIdToken { get; set; }

    }

    public class ApiClaimUpdateRequest
    {
        [Required]
        public string Claim { get; set; }
        [Required]
        public long ServiceId { get; set; }
        [Required]
        public bool RequiredIdToken { get; set; }

    }

    public class UpdateApiClaimStatusDto
    {
        public long Id { get; set; }
        public RecordStatus RecordStatus { get; set; }
     
    }
}
