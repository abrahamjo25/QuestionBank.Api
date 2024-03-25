namespace QuestionBank.Api.Contracts.Choices.Request
{
    public class ChoiceCreateRequest
    {
        public string Label { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public long QuestionId { get; set; }

    }
}
