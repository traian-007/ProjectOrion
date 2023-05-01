using Orion.Domain.Entities.Base;

namespace Orion.Domain.Entities
{
    public class ContactEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public TimeZoneInfo TimeZone { get; set; }
    }
}
