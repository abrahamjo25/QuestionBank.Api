namespace QuestionBank.Api.Contracts.ExamResults.Request
{
    public class ExamResultCreateRequest
    {
        public long ModuleId { get; set; }
        public int Result { get; set; }
    }
}
