namespace QuestionBank.Api.Contracts.Modules.Request
{
    public class ModuleUpdateRequest
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
    }
}
