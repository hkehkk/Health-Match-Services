using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace HealthMatchService.Models
{
    public class Service
    {
        
        [Key]
        public int ServiceId { get; set; }
        
        public string ServiceType { get; set; }
    }
}
