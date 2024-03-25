namespace QuestionBank.Api.Contracts.Payments
{
    public class PaymentCreateRequest
    {
        public long ModuleId { get; set; }
        public double Amount { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
