using HealthMatchService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.ModelBinding;

namespace HealthMatchService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public Clinic AddClinic(Clinic clinic)
        {
            using (HmsContext db = new HmsContext())
            {
                clinic = db.Clinics.Add(clinic);
                db.SaveChanges();
            }
            return clinic; 
        }

        public Doctor AddDoctor(Doctor doctor)
        {
            using (HmsContext db = new HmsContext())
            {
                doctor = db.Doctors.Add(doctor);
                db.SaveChanges();
            }
            return doctor;
        }

        

        public Clinic GetClinic(int id)
        {
            Clinic clinic = null;
            using (HmsContext db = new HmsContext())
            {
                if (id > 0)
                {
                    clinic = db.Clinics.Find(id);
                }
            }

            return clinic;
        }

        public IEnumerable<Clinic> GetClinics()
        {
            List<Clinic> clinics = null;
            using (HmsContext db = new HmsContext())
            {
                clinics = db.Clinics.ToList();
            }
            return clinics;
        }

       public Doctor GetDoctor(int id)
        {
            Doctor doctor = null;
            using (HmsContext db = new HmsContext())
            {
                if (id > 0)
                {
                    doctor = db.Doctors.Find(id);
                }
            }

            return doctor;
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            List<Doctor> doctors = null;
            using (HmsContext db = new HmsContext())
            {
                doctors = db.Doctors.ToList();
            }
            return doctors;
        }

        public Service GetService(int id)
        {
            Service service = null;
            using (HmsContext db = new HmsContext())
            {
                if (id > 0)
                {
                    service = db.Services.Find(id);
                }
            }

            return service;
        }

        public Service AddService(Service service)
        {
            using (HmsContext db = new HmsContext())
            {
                service = db.Services.Add(service);
                db.SaveChanges();
            }
            return service;
        }

        public IEnumerable<Service> GetServices()
        {
            List<Service> services = null;
            using (HmsContext db = new HmsContext())
            {
                services = db.Services.ToList();
            }
            return services;
        }

        public InsuranceCompany GetInsuranceCompany(int id)
        {
            InsuranceCompany insComp = null;
            using (HmsContext db = new HmsContext())
            {
                if (id > 0)
                {
                    insComp = db.InsuranceCompanies.Find(id);
                }
            }

            return insComp;
        }

        public InsuranceCompany AddInsuranceCompany(InsuranceCompany insComp)
        {
            using (HmsContext db = new HmsContext())
            {
                insComp = db.InsuranceCompanies.Add(insComp);
                db.SaveChanges();
            }
            return insComp;
        }

        public IEnumerable<InsuranceCompany> GetInsuranceCompanies()
        {
            List<InsuranceCompany> insComps = null;
            using (HmsContext db = new HmsContext())
            {
                insComps = db.InsuranceCompanies.ToList();
            }
            return insComps;
        }

        public User GetUser(int id)
        {
            User user = null;
            using (HmsContext db = new HmsContext())
            {
                if (id > 0)
                {
                    user = db.Users.Find(id);
                }
            }

            return user;
        }

        public User AddUser(User user)
        {
            using (HmsContext db = new HmsContext())
            {
                user = db.Users.Add(user);
                db.SaveChanges();
            }
            return user;
        }

        public IEnumerable<User> GetUsers()
        {
            List<User> users = null;
            using (HmsContext db = new HmsContext())
            {
                users = db.Users.ToList();
            }
            return users;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

       
    }
}
