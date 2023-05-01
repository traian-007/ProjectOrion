using Orion.Domain.Entities.Base;
using Orion.Domain.Enum;
using System.Net.Http.Json;

namespace Orion.Domain.Entities
{
    public class PackageEntity : BaseEntity
    {
        public string ExternalId { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> Features { get; set; }
        public int Price { get; set; }
        public JsonContent Meta { get; set; }
        public States Status { get; set; }
    }
}
