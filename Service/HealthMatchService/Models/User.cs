using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace HealthMatchService.Models
{
    public class User
    {
        
        [Key]
        public int UserId { get; set; }
        
        [Required]
        public int Zipcode { get; set; }
        
        [Required]
        public string ReasonForVisit { get; set; }
        
        public string InsuranceCompany { get; set; }
        
         
    }
}
