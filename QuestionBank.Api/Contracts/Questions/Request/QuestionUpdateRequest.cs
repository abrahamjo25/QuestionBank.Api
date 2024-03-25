namespace QuestionBank.Api.Contracts.Questions.Request
{
    public class QuestionUpdateRequest
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public string Explanation { get; set; }
        public long ModuleId { get; set; }

    }
}
