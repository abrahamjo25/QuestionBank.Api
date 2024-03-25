using QuestionBank.Api.Contracts.Client.Response;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Api.Contracts.User.Response
{
    public class ClientClaimDetail
    {
        public long Id { get; set; }
        public string Name { get; private set; }
        public string Claim { get; private set; }
        public string Description { get; private set; }
        public ClientDetail Client { get; set; }
        public RecordStatus RecordStatus { get; set; }
    }

}
