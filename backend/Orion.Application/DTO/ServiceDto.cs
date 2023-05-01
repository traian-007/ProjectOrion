using Orion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Application.DTO
{
    public class ServiceDto
    {
        public int Id { get; set; }
        public JsonContent Config { get; set; }
        public int Type { get; set; }
        public string Status { get; set; }
        public string PaymentStatus { get; set; }
        public UserEntity User { get; set; }
        public int UserId { get; set; }
    }
}
