using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Api.Contracts.Client.Response
{
    public class ClientDetail 
    {
        public long Id { get; set; }
        public string ClientName { get; private set; } = string.Empty;
        public string ClientId { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public int AccessTokenLifeTime { get; private set; }
        public int RefreshTokenLifeTime { get; private set; }
        public RecordStatus RecordStatus { get; private set; }
    }

}
