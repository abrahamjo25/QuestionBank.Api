
namespace QuestionBank.Domain.Models.Shared;
public enum UserStatusAction
{
    [Description("Mark As Active")]
    MarkAsActive = 1,
    [Description("Mark As In Active")]
    MarkAsInActive = 2
}

public enum RecordStatus
{
    InActive = 1,
    Active = 2,
    Pending = 3,
    Deleted = 4
}
public enum PaymentStatus
{
    Free = 0,
    OnProgress = 1,
    Payed = 2,
}
