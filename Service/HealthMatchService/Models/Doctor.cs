using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace HealthMatchService.Models
{
    public class Doctor
    {
        
        [Key]
        public int DoctorId { get; set; }        
        public string Name { get; set; }        
        public string TypeOfPhysician { get; set; }        
        public string Treatments { get; set; }
        public Clinic Clinic { get; set; }
        public int? ClinicId { get; set; }
       




    }
}
