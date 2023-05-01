using Orion.Domain.Entities.Base;
using Orion.Domain.Enum;

namespace Orion.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }
        public ContactEntity Contact { get; set; }
        public int ContactId { get; set; }
    }
}
