using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

using System.Data.Entity.Infrastructure;

namespace HealthMatchService.Models
{
    public class HmsContext : DbContext
    {
        public HmsContext() : base("HealthMatchService.ConnectionString")
        { 

        }

        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<InsuranceCompany> InsuranceCompanies { get; set; }


    }
}