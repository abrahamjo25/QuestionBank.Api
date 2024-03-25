namespace QuestionBank.Api.Contracts.Modules.Response
{
    public class ModuleDetail
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long CourseId { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }

    }
}
