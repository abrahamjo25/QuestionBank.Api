using QuestionBank.Domain.Models.Shared;
using QuestionBank.Domain.Validator.QuestionBanks;

namespace QuestionBank.Domain.Models.QuestionBanks
{
    public class Choice : BaseEntity
    {
        public string? Label { get; private set; }
        public string? Text { get; private set; }
        public bool IsCorrect { get; private set; }

        public long QuestionId { get; private set; }
        public virtual Question Question { get; private set; }
        public static Choice Create(string label, string text,bool isCorrect,long questionId, long id = 0, bool isreadonly = false)
        {
            var validator = new ChoiceValidator();
            var choice = new Choice
            {
                Id = id,
                Label = label,
                Text = text,
                IsCorrect = isCorrect,
                QuestionId = questionId,
                RecordStatus = RecordStatus.Active,
                IsReadOnly = isreadonly
            };
            var validationResult = validator.Validate(choice);
            if (validationResult.IsValid) return choice;
            var exception = new NotValidException("Choice is not valid");
            validationResult.Errors.ForEach(vr => exception.ValidationErrors.Add(vr.ErrorMessage));
            throw exception;
        }

        public void Update(string label, string text, bool isCorrect,long questionId)
        {
            Label = label;
            Text = text;
            IsCorrect = isCorrect;
            QuestionId = questionId;
        }

        public void UpdateStatus(RecordStatus status)
        {
            RecordStatus = status;
        }
    }
}
