using System.ComponentModel;

namespace QuestionBank.Application.Helpers.Common;
public enum RecordStatuss
{
    [Description("InActive")]
    Inactive = 1,
    [Description("Active")]
    Active = 2,
    [Description("Deleted")]
    Deleted = 3
}
