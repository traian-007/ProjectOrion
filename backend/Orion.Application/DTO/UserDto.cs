using Orion.Domain.Enum;

namespace Orion.Application.DTO
{
    public class UserDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }
        public ContactDto Contact { get; set; }
        public int ContactId { get; set; }
    }
}
