namespace QuestionBank.Api.Contracts.Courses.Request
{
    public class CourseUpdateRequest
    {
        public long Id { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
    }
}
