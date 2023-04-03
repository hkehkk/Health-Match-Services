using HealthMatchService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HealthMatchService
{
    
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        Clinic GetClinic(int id);

        [OperationContract]
        Clinic AddClinic(Clinic clinic);

        [OperationContract]
        IEnumerable<Clinic> GetClinics();

        [OperationContract]
        Doctor GetDoctor(int id);

        [OperationContract]
        Doctor AddDoctor(Doctor doctor);

        [OperationContract]
        IEnumerable<Doctor> GetDoctors();

        [OperationContract]
        Service GetService(int id);

        [OperationContract]
        Service AddService(Service service);

        [OperationContract]
        IEnumerable<Service> GetServices();

        [OperationContract]
        InsuranceCompany GetInsuranceCompany(int id);

        [OperationContract]
        InsuranceCompany AddInsuranceCompany(InsuranceCompany insComp);

        [OperationContract]
        IEnumerable<InsuranceCompany> GetInsuranceCompanies();

        [OperationContract]
        User GetUser(int id);

        [OperationContract]
        User AddUser(User user);

        [OperationContract]
        IEnumerable<User> GetUsers();

                
    }


    
    
}
