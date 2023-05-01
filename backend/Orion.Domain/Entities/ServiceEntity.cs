using Orion.Domain.Entities.Base;
using System.Net.Http.Json;

namespace Orion.Domain.Entities
{
    public class Service : BaseEntity
    {
        public JsonContent Config { get; set; }
        public int Type { get; set; }
        public string Status { get; set; }
        public string PaymentStatus { get; set; }
        public UserEntity User { get; set; }
        public int UserId { get; set; }
    }
}
