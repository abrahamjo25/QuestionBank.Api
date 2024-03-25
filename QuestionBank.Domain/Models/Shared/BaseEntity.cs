namespace QuestionBank.Domain.Models.Shared
{
    public class BaseEntity
    {
        public long Id { get; set; }

        //Auditlog
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } = DateTime.MaxValue;
        public string TimeZoneInfo { get; set; } = string.Empty;
        public DateTime RegisteredDate { get; set; }
        public string RegisteredBy { get; set; } = string.Empty;
        public DateTime LastUpdateDate { get; set; }
        public string UpdatedBy { get; set; } = string.Empty;
        public RecordStatus RecordStatus { get; set; }
        public bool IsReadOnly { get; set; }

        public BaseEntity()
        {
            StartDate = DateTime.UtcNow;
            EndDate = DateTime.MaxValue;
            RegisteredDate = DateTime.UtcNow;
            LastUpdateDate = DateTime.UtcNow;
            IsReadOnly = false;
            RecordStatus = RecordStatus.Active;

        }
        public virtual void UpdateAudit(string updateBy)
        {
            LastUpdateDate = DateTime.UtcNow;
            UpdatedBy = _setEmptyString(updateBy);

        }
        public virtual void UpdateRecordStatus(RecordStatus status, string updateBy = "")
        {
            RecordStatus = status;
            LastUpdateDate = DateTime.UtcNow;
            UpdatedBy = updateBy;
        }
        public virtual void Register(string updateBy)
        {
            RegisteredDate = DateTime.UtcNow;
            StartDate = DateTime.UtcNow;
            RegisteredBy = _setEmptyString(updateBy);

        }
        public virtual void Delete(string deletedBy = "")
        {
            RecordStatus = RecordStatus.Deleted;
            LastUpdateDate = DateTime.UtcNow;
            UpdatedBy = deletedBy;
        }
        protected static string _setEmptyString(string value) => String.IsNullOrEmpty(value) ? String.Empty : value;

    }
}
