namespace QuestionBank.Api.Contracts.Questions.Response
{
    public class QuestionsWithChoicesCreate
    {
        public string Text { get; set; }
        public string Explanation { get; set; }
        public long ModuleId { get; set; }
        public List<ChoiceDtoCreate> Choices { get; set; }
    }

    public class ChoiceDtoCreate
    {
        public string Label { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }
}
