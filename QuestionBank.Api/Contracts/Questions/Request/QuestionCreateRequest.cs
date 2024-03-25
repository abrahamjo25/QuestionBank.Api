namespace QuestionBank.Api.Contracts.Questions.Request
{
    public class QuestionCreateRequest
    {
        public string Text { get; set; }
        public string Explanation { get; set; }
        public long ModuleId { get; set; }
    }
}
