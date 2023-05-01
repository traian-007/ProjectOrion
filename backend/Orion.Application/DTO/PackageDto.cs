using Orion.Domain.Enum;
using System.Net.Http.Json;

namespace Orion.Application.DTO
{
    public class PackageDto
    {
        public int Id { get; set; }
        public string ExternalId { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> Features { get; set; }
        public int Price { get; set; }
        public JsonContent Meta { get; set; }
        public States Status { get; set; }
    }
}
