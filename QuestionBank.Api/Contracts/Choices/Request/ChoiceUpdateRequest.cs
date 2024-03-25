namespace QuestionBank.Api.Contracts.Choices.Request
{
    public class ChoiceUpdateRequest
    {
        public long Id { get; set; }
        public string Label { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public long QuestionId { get; set; }

    }
}
