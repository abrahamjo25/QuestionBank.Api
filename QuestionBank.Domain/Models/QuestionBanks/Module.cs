using QuestionBank.Domain.Validator.QuestionBanks;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Domain.Models.QuestionBanks
{
    public class Module : BaseEntity
    {
        public string? Name { get; private set; }
        public string? Description { get; private set; }
        public double Price { get; set; }
        public int Discount { get; set; }
        public long CourseId { get; private set; }
        public virtual Course Course { get; private set; }
        public virtual List<Question> Question { get; private set; } 
        public virtual List<UserModule> UserModule { get; private set; }

        public static Module Create(string name, string description, double price, int discount, long courseId, long id = 0, bool isreadonly = false)
        {
            var validator = new ModuleValidator();
            var module = new Module
            {
                Id = id,
                Name = name,
                Description = description,
                Price = price,
                Discount = discount,
                CourseId= courseId,
                RecordStatus = RecordStatus.Active,
                IsReadOnly = isreadonly
            };
            var validationResult = validator.Validate(module);
            if (validationResult.IsValid) return module;
            var exception = new NotValidException("Module is not valid");
            validationResult.Errors.ForEach(vr => exception.ValidationErrors.Add(vr.ErrorMessage));
            throw exception;
        }

        public void Update(string name, string description, double price, int discount)
        {
            Name = name;
            Description = description;
            Price = price;
            Discount = discount;
        }

        public void UpdateStatus(RecordStatus status)
        {
            RecordStatus = status;
        }
    }
}
