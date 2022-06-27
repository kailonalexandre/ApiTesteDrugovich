using Api.Domain.Models;

namespace Api.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public RoleLevel Level { get; set; }
    }
}
