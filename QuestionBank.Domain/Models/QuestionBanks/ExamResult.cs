using QuestionBank.Domain.Models.Shared;
using QuestionBank.Domain.Validator.QuestionBanks;

namespace QuestionBank.Domain.Models.QuestionBanks
{
    public class ExamResult : BaseEntity
    {
        public string UserId { get; private set; }
        public long UserModuleId { get; private set; }
        public int Result { get; private set; }
        public UserModule UserModule { get; private set; }
        public static ExamResult Create(long moduleId, string userId, int result, long id = 0, bool isreadonly = false)
        {
            var validator = new ExamResultValidator();
            var module = new ExamResult
            {
                Id = id,
                UserModuleId = moduleId,
                UserId = userId,
                Result = result,
                RecordStatus = RecordStatus.Active,
                IsReadOnly = isreadonly
            };
            var validationResult = validator.Validate(module);
            if (validationResult.IsValid) return module;
            var exception = new NotValidException("Module is not valid");
            validationResult.Errors.ForEach(vr => exception.ValidationErrors.Add(vr.ErrorMessage));
            throw exception;
        }
    }
}
