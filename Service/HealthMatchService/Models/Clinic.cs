using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace HealthMatchService.Models
{
    public class Clinic
    {
        
        [Key]
        public int ClinicId { get; set; }
        
        public string ClinicName { get; set; }
        
        public string Address { get; set; }
        
        public string City { get; set; }
        
        public string State { get; set; }
        
        public string Zipcode { get; set; }
        
        public string Phone { get; set; }
        
        public Service Service { get; set; }
        
        public int? ServiceId { get; set; }


    }
}
