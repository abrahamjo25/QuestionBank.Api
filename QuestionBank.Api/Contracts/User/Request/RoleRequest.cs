using System.ComponentModel.DataAnnotations;
using QuestionBank.Domain.Models.Shared;
namespace QuestionBank.Api.Contracts.User.Request
{
    public class RoleRequest
    {
        [Required]

        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public long ClientId { get; set; }
        [Required]
        public List<long> Claims { get; set; }
        public RoleRequest()
        {
            Claims = new List<long>();
        }
    }

    public class UpdateRoleStatusDto
    {
        public RecordStatus RecordStatus { get; set; }
        public long Id { get; set; }
    }
}
