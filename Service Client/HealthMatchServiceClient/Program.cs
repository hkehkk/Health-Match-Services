using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HealthMatchServiceClient.ServiceReference1;

namespace HealthMatchServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IService1 svc = new Service1Client();

            Clinic clinic1 = new Clinic();
            clinic1.ClinicId = 2;
            clinic1.ClinicName = "Urgent Care";
            clinic1.Phone = "4096548723";

            clinic1 = svc.AddClinic(clinic1);


            List<Clinic> clinics = svc.GetClinics().ToList();
            clinics = svc.GetClinics().ToList();
            foreach (Clinic c in clinics)
            {
                Console.WriteLine(c.ClinicId + " " + c.ClinicName + " " + c.Phone);
            }
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
