using QuestionBank.Domain.Validator.QuestionBanks;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Domain.Models.QuestionBanks
{
    public class Question : BaseEntity
    {
        public string? Text { get; private set; }
        public string? Explanation { get; private set; }
        public long ModuleId { get; private set; }
        public virtual Module Module { get; private set; }
        public virtual List<Choice> Choice { get; private set; }
        public static Question Create(string text, string explanation,long moduleId, long id = 0, bool isreadonly = false)
        {
            var validator = new QuestionValidator();
            var question = new Question
            {
                Id = id,
                Text = text,
                Explanation = explanation,
                ModuleId = moduleId,
                RecordStatus = RecordStatus.Active,
                IsReadOnly = isreadonly
            };
            var validationResult = validator.Validate(question);
            if (validationResult.IsValid) return question;
            var exception = new NotValidException("Question is not valid");
            validationResult.Errors.ForEach(vr => exception.ValidationErrors.Add(vr.ErrorMessage));
            throw exception;
        }

        public void Update(string text, string explanation,long moduleId)
        {
            Text = text;
            Explanation = explanation;
            ModuleId = moduleId;
        }

        public void UpdateStatus(RecordStatus status)
        {
            RecordStatus = status;
        }
    }
}
