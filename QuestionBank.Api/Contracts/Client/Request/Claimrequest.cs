using System.ComponentModel.DataAnnotations;

namespace QuestionBank.Api.Contracts.Client.Request
{
    public class Claimrequest
    {
        public int serviceId { get; set; }
        public List<string> claim { get; set; }
        public bool requiredIdToken { get; set; }

    }
}
