namespace QuestionBank.Api.Contracts.Modules.Request
{
    public class ModuleCreateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
        public int CourseId { get; set; }
    }
}
