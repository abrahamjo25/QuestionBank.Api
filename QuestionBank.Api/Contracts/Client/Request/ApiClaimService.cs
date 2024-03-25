using System.ComponentModel.DataAnnotations;

namespace QuestionBank.Api.Contracts.Client.Request
{
    public class ApiClaimService
    {
        public string Claim { get; set; }
        public bool RequiredIdToken { get; set; }
    }
}
