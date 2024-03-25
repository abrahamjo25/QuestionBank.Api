namespace QuestionBank.Api.Contracts.Questions.Response
{
    public class QuestionsWithChoicesUpdate
    {
        public string Text { get; set; }
        public string Explanation { get; set; }
        public long ModuleId { get; set; }
        public List<ChoiceDtoUpdate> Choices { get; set; }
    }

    public class ChoiceDtoUpdate
    {
        public long Id { get; set; }
        public string Label { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }
}
