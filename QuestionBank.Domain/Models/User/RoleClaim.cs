using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Domain.Models.User
{
    public class RoleClaim : BaseEntity
    {
        public long? RoleId { get; set; }
        public long? ClientClaimId { get; set; }
        public virtual ClientClaim ClientClaim { get; set; }
        public virtual Role Role { get; set; }
    }
}
