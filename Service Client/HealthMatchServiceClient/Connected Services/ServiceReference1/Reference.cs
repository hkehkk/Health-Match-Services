﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HealthMatchServiceClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Clinic", Namespace="http://schemas.datacontract.org/2004/07/HealthMatchService.Models")]
    [System.SerializableAttribute()]
    public partial class Clinic : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClinicIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClinicNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HealthMatchServiceClient.ServiceReference1.Service ServiceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ServiceIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ZipcodeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ClinicId {
            get {
                return this.ClinicIdField;
            }
            set {
                if ((this.ClinicIdField.Equals(value) != true)) {
                    this.ClinicIdField = value;
                    this.RaisePropertyChanged("ClinicId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClinicName {
            get {
                return this.ClinicNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ClinicNameField, value) != true)) {
                    this.ClinicNameField = value;
                    this.RaisePropertyChanged("ClinicName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HealthMatchServiceClient.ServiceReference1.Service Service {
            get {
                return this.ServiceField;
            }
            set {
                if ((object.ReferenceEquals(this.ServiceField, value) != true)) {
                    this.ServiceField = value;
                    this.RaisePropertyChanged("Service");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ServiceId {
            get {
                return this.ServiceIdField;
            }
            set {
                if ((this.ServiceIdField.Equals(value) != true)) {
                    this.ServiceIdField = value;
                    this.RaisePropertyChanged("ServiceId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Zipcode {
            get {
                return this.ZipcodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ZipcodeField, value) != true)) {
                    this.ZipcodeField = value;
                    this.RaisePropertyChanged("Zipcode");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Service", Namespace="http://schemas.datacontract.org/2004/07/HealthMatchService.Models")]
    [System.SerializableAttribute()]
    public partial class Service : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ServiceIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServiceTypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ServiceId {
            get {
                return this.ServiceIdField;
            }
            set {
                if ((this.ServiceIdField.Equals(value) != true)) {
                    this.ServiceIdField = value;
                    this.RaisePropertyChanged("ServiceId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServiceType {
            get {
                return this.ServiceTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ServiceTypeField, value) != true)) {
                    this.ServiceTypeField = value;
                    this.RaisePropertyChanged("ServiceType");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Doctor", Namespace="http://schemas.datacontract.org/2004/07/HealthMatchService.Models")]
    [System.SerializableAttribute()]
    public partial class Doctor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HealthMatchServiceClient.ServiceReference1.Clinic ClinicField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ClinicIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DoctorIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TreatmentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeOfPhysicianField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HealthMatchServiceClient.ServiceReference1.Clinic Clinic {
            get {
                return this.ClinicField;
            }
            set {
                if ((object.ReferenceEquals(this.ClinicField, value) != true)) {
                    this.ClinicField = value;
                    this.RaisePropertyChanged("Clinic");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ClinicId {
            get {
                return this.ClinicIdField;
            }
            set {
                if ((this.ClinicIdField.Equals(value) != true)) {
                    this.ClinicIdField = value;
                    this.RaisePropertyChanged("ClinicId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DoctorId {
            get {
                return this.DoctorIdField;
            }
            set {
                if ((this.DoctorIdField.Equals(value) != true)) {
                    this.DoctorIdField = value;
                    this.RaisePropertyChanged("DoctorId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Treatments {
            get {
                return this.TreatmentsField;
            }
            set {
                if ((object.ReferenceEquals(this.TreatmentsField, value) != true)) {
                    this.TreatmentsField = value;
                    this.RaisePropertyChanged("Treatments");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TypeOfPhysician {
            get {
                return this.TypeOfPhysicianField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeOfPhysicianField, value) != true)) {
                    this.TypeOfPhysicianField = value;
                    this.RaisePropertyChanged("TypeOfPhysician");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InsuranceCompany", Namespace="http://schemas.datacontract.org/2004/07/HealthMatchService.Models")]
    [System.SerializableAttribute()]
    public partial class InsuranceCompany : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HealthMatchServiceClient.ServiceReference1.Clinic ClinicField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ClinicIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int InsuranceIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HealthMatchServiceClient.ServiceReference1.Clinic Clinic {
            get {
                return this.ClinicField;
            }
            set {
                if ((object.ReferenceEquals(this.ClinicField, value) != true)) {
                    this.ClinicField = value;
                    this.RaisePropertyChanged("Clinic");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ClinicId {
            get {
                return this.ClinicIdField;
            }
            set {
                if ((this.ClinicIdField.Equals(value) != true)) {
                    this.ClinicIdField = value;
                    this.RaisePropertyChanged("ClinicId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int InsuranceId {
            get {
                return this.InsuranceIdField;
            }
            set {
                if ((this.InsuranceIdField.Equals(value) != true)) {
                    this.InsuranceIdField = value;
                    this.RaisePropertyChanged("InsuranceId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/HealthMatchService.Models")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InsuranceCompanyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReasonForVisitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ZipcodeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InsuranceCompany {
            get {
                return this.InsuranceCompanyField;
            }
            set {
                if ((object.ReferenceEquals(this.InsuranceCompanyField, value) != true)) {
                    this.InsuranceCompanyField = value;
                    this.RaisePropertyChanged("InsuranceCompany");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReasonForVisit {
            get {
                return this.ReasonForVisitField;
            }
            set {
                if ((object.ReferenceEquals(this.ReasonForVisitField, value) != true)) {
                    this.ReasonForVisitField = value;
                    this.RaisePropertyChanged("ReasonForVisit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Zipcode {
            get {
                return this.ZipcodeField;
            }
            set {
                if ((this.ZipcodeField.Equals(value) != true)) {
                    this.ZipcodeField = value;
                    this.RaisePropertyChanged("Zipcode");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClinic", ReplyAction="http://tempuri.org/IService1/GetClinicResponse")]
        HealthMatchServiceClient.ServiceReference1.Clinic GetClinic(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClinic", ReplyAction="http://tempuri.org/IService1/GetClinicResponse")]
        System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.Clinic> GetClinicAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddClinic", ReplyAction="http://tempuri.org/IService1/AddClinicResponse")]
        HealthMatchServiceClient.ServiceReference1.Clinic AddClinic(HealthMatchServiceClient.ServiceReference1.Clinic clinic);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddClinic", ReplyAction="http://tempuri.org/IService1/AddClinicResponse")]
        System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.Clinic> AddClinicAsync(HealthMatchServiceClient.ServiceReference1.Clinic clinic);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClinics", ReplyAction="http://tempuri.org/IService1/GetClinicsResponse")]
        HealthMatchServiceClient.ServiceReference1.Clinic[] GetClinics();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClinics", ReplyAction="http://tempuri.org/IService1/GetClinicsResponse")]
        System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.Clinic[]> GetClinicsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDoctor", ReplyAction="http://tempuri.org/IService1/GetDoctorResponse")]
        HealthMatchServiceClient.ServiceReference1.Doctor GetDoctor(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDoctor", ReplyAction="http://tempuri.org/IService1/GetDoctorResponse")]
        System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.Doctor> GetDoctorAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddDoctor", ReplyAction="http://tempuri.org/IService1/AddDoctorResponse")]
        HealthMatchServiceClient.ServiceReference1.Doctor AddDoctor(HealthMatchServiceClient.ServiceReference1.Doctor doctor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddDoctor", ReplyAction="http://tempuri.org/IService1/AddDoctorResponse")]
        System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.Doctor> AddDoctorAsync(HealthMatchServiceClient.ServiceReference1.Doctor doctor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDoctors", ReplyAction="http://tempuri.org/IService1/GetDoctorsResponse")]
        HealthMatchServiceClient.ServiceReference1.Doctor[] GetDoctors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDoctors", ReplyAction="http://tempuri.org/IService1/GetDoctorsResponse")]
        System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.Doctor[]> GetDoctorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetService", ReplyAction="http://tempuri.org/IService1/GetServiceResponse")]
        HealthMatchServiceClient.ServiceReference1.Service GetService(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetService", ReplyAction="http://tempuri.org/IService1/GetServiceResponse")]
        System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.Service> GetServiceAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddService", ReplyAction="http://tempuri.org/IService1/AddServiceResponse")]
        HealthMatchServiceClient.ServiceReference1.Service AddService(HealthMatchServiceClient.ServiceReference1.Service service);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddService", ReplyAction="http://tempuri.org/IService1/AddServiceResponse")]
        System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.Service> AddServiceAsync(HealthMatchServiceClient.ServiceReference1.Service service);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetServices", ReplyAction="http://tempuri.org/IService1/GetServicesResponse")]
        HealthMatchServiceClient.ServiceReference1.Service[] GetServices();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetServices", ReplyAction="http://tempuri.org/IService1/GetServicesResponse")]
        System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.Service[]> GetServicesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetInsuranceCompany", ReplyAction="http://tempuri.org/IService1/GetInsuranceCompanyResponse")]
        HealthMatchServiceClient.ServiceReference1.InsuranceCompany GetInsuranceCompany(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetInsuranceCompany", ReplyAction="http://tempuri.org/IService1/GetInsuranceCompanyResponse")]
        System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.InsuranceCompany> GetInsuranceCompanyAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddInsuranceCompany", ReplyAction="http://tempuri.org/IService1/AddInsuranceCompanyResponse")]
        HealthMatchServiceClient.ServiceReference1.InsuranceCompany AddInsuranceCompany(HealthMatchServiceClient.ServiceReference1.InsuranceCompany insComp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddInsuranceCompany", ReplyAction="http://tempuri.org/IService1/AddInsuranceCompanyResponse")]
        System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.InsuranceCompany> AddInsuranceCompanyAsync(HealthMatchServiceClient.ServiceReference1.InsuranceCompany insComp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetInsuranceCompanies", ReplyAction="http://tempuri.org/IService1/GetInsuranceCompaniesResponse")]
        HealthMatchServiceClient.ServiceReference1.InsuranceCompany[] GetInsuranceCompanies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetInsuranceCompanies", ReplyAction="http://tempuri.org/IService1/GetInsuranceCompaniesResponse")]
        System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.InsuranceCompany[]> GetInsuranceCompaniesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUser", ReplyAction="http://tempuri.org/IService1/GetUserResponse")]
        HealthMatchServiceClient.ServiceReference1.User GetUser(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUser", ReplyAction="http://tempuri.org/IService1/GetUserResponse")]
        System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.User> GetUserAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddUser", ReplyAction="http://tempuri.org/IService1/AddUserResponse")]
        HealthMatchServiceClient.ServiceReference1.User AddUser(HealthMatchServiceClient.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddUser", ReplyAction="http://tempuri.org/IService1/AddUserResponse")]
        System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.User> AddUserAsync(HealthMatchServiceClient.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUsers", ReplyAction="http://tempuri.org/IService1/GetUsersResponse")]
        HealthMatchServiceClient.ServiceReference1.User[] GetUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUsers", ReplyAction="http://tempuri.org/IService1/GetUsersResponse")]
        System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.User[]> GetUsersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : HealthMatchServiceClient.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<HealthMatchServiceClient.ServiceReference1.IService1>, HealthMatchServiceClient.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public HealthMatchServiceClient.ServiceReference1.Clinic GetClinic(int id) {
            return base.Channel.GetClinic(id);
        }
        
        public System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.Clinic> GetClinicAsync(int id) {
            return base.Channel.GetClinicAsync(id);
        }
        
        public HealthMatchServiceClient.ServiceReference1.Clinic AddClinic(HealthMatchServiceClient.ServiceReference1.Clinic clinic) {
            return base.Channel.AddClinic(clinic);
        }
        
        public System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.Clinic> AddClinicAsync(HealthMatchServiceClient.ServiceReference1.Clinic clinic) {
            return base.Channel.AddClinicAsync(clinic);
        }
        
        public HealthMatchServiceClient.ServiceReference1.Clinic[] GetClinics() {
            return base.Channel.GetClinics();
        }
        
        public System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.Clinic[]> GetClinicsAsync() {
            return base.Channel.GetClinicsAsync();
        }
        
        public HealthMatchServiceClient.ServiceReference1.Doctor GetDoctor(int id) {
            return base.Channel.GetDoctor(id);
        }
        
        public System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.Doctor> GetDoctorAsync(int id) {
            return base.Channel.GetDoctorAsync(id);
        }
        
        public HealthMatchServiceClient.ServiceReference1.Doctor AddDoctor(HealthMatchServiceClient.ServiceReference1.Doctor doctor) {
            return base.Channel.AddDoctor(doctor);
        }
        
        public System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.Doctor> AddDoctorAsync(HealthMatchServiceClient.ServiceReference1.Doctor doctor) {
            return base.Channel.AddDoctorAsync(doctor);
        }
        
        public HealthMatchServiceClient.ServiceReference1.Doctor[] GetDoctors() {
            return base.Channel.GetDoctors();
        }
        
        public System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.Doctor[]> GetDoctorsAsync() {
            return base.Channel.GetDoctorsAsync();
        }
        
        public HealthMatchServiceClient.ServiceReference1.Service GetService(int id) {
            return base.Channel.GetService(id);
        }
        
        public System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.Service> GetServiceAsync(int id) {
            return base.Channel.GetServiceAsync(id);
        }
        
        public HealthMatchServiceClient.ServiceReference1.Service AddService(HealthMatchServiceClient.ServiceReference1.Service service) {
            return base.Channel.AddService(service);
        }
        
        public System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.Service> AddServiceAsync(HealthMatchServiceClient.ServiceReference1.Service service) {
            return base.Channel.AddServiceAsync(service);
        }
        
        public HealthMatchServiceClient.ServiceReference1.Service[] GetServices() {
            return base.Channel.GetServices();
        }
        
        public System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.Service[]> GetServicesAsync() {
            return base.Channel.GetServicesAsync();
        }
        
        public HealthMatchServiceClient.ServiceReference1.InsuranceCompany GetInsuranceCompany(int id) {
            return base.Channel.GetInsuranceCompany(id);
        }
        
        public System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.InsuranceCompany> GetInsuranceCompanyAsync(int id) {
            return base.Channel.GetInsuranceCompanyAsync(id);
        }
        
        public HealthMatchServiceClient.ServiceReference1.InsuranceCompany AddInsuranceCompany(HealthMatchServiceClient.ServiceReference1.InsuranceCompany insComp) {
            return base.Channel.AddInsuranceCompany(insComp);
        }
        
        public System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.InsuranceCompany> AddInsuranceCompanyAsync(HealthMatchServiceClient.ServiceReference1.InsuranceCompany insComp) {
            return base.Channel.AddInsuranceCompanyAsync(insComp);
        }
        
        public HealthMatchServiceClient.ServiceReference1.InsuranceCompany[] GetInsuranceCompanies() {
            return base.Channel.GetInsuranceCompanies();
        }
        
        public System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.InsuranceCompany[]> GetInsuranceCompaniesAsync() {
            return base.Channel.GetInsuranceCompaniesAsync();
        }
        
        public HealthMatchServiceClient.ServiceReference1.User GetUser(int id) {
            return base.Channel.GetUser(id);
        }
        
        public System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.User> GetUserAsync(int id) {
            return base.Channel.GetUserAsync(id);
        }
        
        public HealthMatchServiceClient.ServiceReference1.User AddUser(HealthMatchServiceClient.ServiceReference1.User user) {
            return base.Channel.AddUser(user);
        }
        
        public System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.User> AddUserAsync(HealthMatchServiceClient.ServiceReference1.User user) {
            return base.Channel.AddUserAsync(user);
        }
        
        public HealthMatchServiceClient.ServiceReference1.User[] GetUsers() {
            return base.Channel.GetUsers();
        }
        
        public System.Threading.Tasks.Task<HealthMatchServiceClient.ServiceReference1.User[]> GetUsersAsync() {
            return base.Channel.GetUsersAsync();
        }
    }
}
