using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace HealthMatchService.Models
{
    public class InsuranceCompany
    {
        
        [Key]
        public int InsuranceId { get; set; }
        
        public string Name { get; set; }
        
        public Clinic Clinic { get; set; }
        
        public int? ClinicId { get; set; }
        
    }
}
