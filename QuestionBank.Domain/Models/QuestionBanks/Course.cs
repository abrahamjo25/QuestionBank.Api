using QuestionBank.Domain.Validator.QuestionBanks;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Domain.Models.QuestionBanks
{
    public class Course : BaseEntity
    {
        public string? CourseName { get; private set; }
        public string? Description { get; private set; }
        public virtual List<Module>? Module { get; private set; }
        public static Course Create(string name, string description, long id = 0, bool isreadonly = false)
        {
            var validator = new CourseValidator();
            var course = new Course
            {
                Id = id,
                CourseName = name,
                Description = description,
                RecordStatus = RecordStatus.Active,
                IsReadOnly = isreadonly
            };
            var validationResult = validator.Validate(course);
            if (validationResult.IsValid) return course;
            var exception = new NotValidException("Course is not valid");
            validationResult.Errors.ForEach(vr => exception.ValidationErrors.Add(vr.ErrorMessage));
            throw exception;
        }

        public void Update(string name, string description)
        {
            CourseName = name;
            Description = description;
        }

        public void UpdateStatus(RecordStatus status)
        {
            RecordStatus = status;
        }

    }
}
