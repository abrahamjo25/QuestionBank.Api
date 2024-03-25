using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Domain.Models
{
    public class IdentityUserRole : BaseEntity
    {
        public long UserId { get; set; }
        public long RoleId { get; set; }
        public virtual IdentityUser User { get; set; }
        public virtual Role Role { get; set; }


    }
}
