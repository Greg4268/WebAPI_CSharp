using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string MoistureStatus { get; set; } = string.Empty; 
        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}