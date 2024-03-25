namespace QuestionBank.Api.Contracts.Choices.Response
{
    public class ChoiceDetail
    {
        public long Id { get; set; }
        public string Label { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }
}
