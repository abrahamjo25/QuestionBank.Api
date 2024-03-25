using QuestionBank.Domain.Models.Shared;
using QuestionBank.Domain.Validator.QuestionBanks;

namespace QuestionBank.Domain.Models.QuestionBanks
{
    public class UserModule : BaseEntity
    {
        public string? Username { get; private set; }
        public string ? Reference { get; private set; }
        public PaymentStatus ? Payment { get; private set; }
        public long ModuleId { get; private set; }
        public virtual Module Module { get; private set; }
        public virtual List<ExamResult> ExamResults { get; private set; }
        public static UserModule Create(string username, long moduleId, long id = 0, bool isreadonly = false)
        {
            var validator = new UserModuleValidator();
            var userModule = new UserModule
            {
                Id = id,
                Username = username,
                ModuleId = moduleId,
                Payment = PaymentStatus.Free,
                RecordStatus = RecordStatus.Active,
                IsReadOnly = isreadonly
            };
            var validationResult = validator.Validate(userModule);
            if (validationResult.IsValid) return userModule;
            var exception = new NotValidException("Module is not valid");
            validationResult.Errors.ForEach(vr => exception.ValidationErrors.Add(vr.ErrorMessage));
            throw exception;
        }
        public static UserModule CreatePayment(string username, long moduleId,string reference, long id = 0, bool isreadonly = false)
        {
            var validator = new UserModuleValidator();
            var userModule = new UserModule
            {
                Id = id,
                Username = username,
                ModuleId = moduleId,
                Payment = PaymentStatus.OnProgress,
                Reference = reference,
                RecordStatus = RecordStatus.Active,
                IsReadOnly = isreadonly
            };
            var validationResult = validator.Validate(userModule);
            if (validationResult.IsValid) return userModule;
            var exception = new NotValidException("Module is not valid");
            validationResult.Errors.ForEach(vr => exception.ValidationErrors.Add(vr.ErrorMessage));
            throw exception;
        }
        public void UpdateStatus(PaymentStatus payment)
        {
            Payment = payment;
        } 
        public void UpdateReference(string reference)
        {
            Reference = reference;
        }
        public void DeleteStatus(RecordStatus recordStatus)
        {
            RecordStatus = recordStatus;
        }
    }
}
