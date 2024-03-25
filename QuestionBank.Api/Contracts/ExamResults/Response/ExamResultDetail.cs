namespace QuestionBank.Api.Contracts.ExamResults.Response
{
    public class ExamResultDetail
    {
        public long Id { get; set; }
        public long ModuleId { get; set; }
        public string UserId { get;set; }
        public int Result {  get; set; }
    }
}
