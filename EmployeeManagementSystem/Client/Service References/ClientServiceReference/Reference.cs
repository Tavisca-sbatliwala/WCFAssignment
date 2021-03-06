﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ClientServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeManagement", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
    [System.SerializableAttribute()]
    public partial class EmployeeManagement : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeSubmittedField;
        
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
        public string Comment {
            get {
                return this.CommentField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentField, value) != true)) {
                    this.CommentField = value;
                    this.RaisePropertyChanged("Comment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EmployeeID {
            get {
                return this.EmployeeIDField;
            }
            set {
                if ((this.EmployeeIDField.Equals(value) != true)) {
                    this.EmployeeIDField = value;
                    this.RaisePropertyChanged("EmployeeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmployeeName {
            get {
                return this.EmployeeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeNameField, value) != true)) {
                    this.EmployeeNameField = value;
                    this.RaisePropertyChanged("EmployeeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeSubmitted {
            get {
                return this.TimeSubmittedField;
            }
            set {
                if ((this.TimeSubmittedField.Equals(value) != true)) {
                    this.TimeSubmittedField = value;
                    this.RaisePropertyChanged("TimeSubmitted");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
    [System.SerializableAttribute()]
    public partial class EmployeeServiceFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FaultDetailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FaultIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FaultMessageField;
        
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
        public string FaultDetail {
            get {
                return this.FaultDetailField;
            }
            set {
                if ((object.ReferenceEquals(this.FaultDetailField, value) != true)) {
                    this.FaultDetailField = value;
                    this.RaisePropertyChanged("FaultDetail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FaultId {
            get {
                return this.FaultIdField;
            }
            set {
                if ((this.FaultIdField.Equals(value) != true)) {
                    this.FaultIdField = value;
                    this.RaisePropertyChanged("FaultId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FaultMessage {
            get {
                return this.FaultMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.FaultMessageField, value) != true)) {
                    this.FaultMessageField = value;
                    this.RaisePropertyChanged("FaultMessage");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClientServiceReference.IEmployeeCreate")]
    public interface IEmployeeCreate {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/CreateEmployee", ReplyAction="http://tempuri.org/IEmployeeCreate/CreateEmployeeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Client.ClientServiceReference.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeCreate/CreateEmployeeEmployeeServiceFaultFault", Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
        Client.ClientServiceReference.EmployeeManagement CreateEmployee(int id, string name, string comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/CreateEmployee", ReplyAction="http://tempuri.org/IEmployeeCreate/CreateEmployeeResponse")]
        System.Threading.Tasks.Task<Client.ClientServiceReference.EmployeeManagement> CreateEmployeeAsync(int id, string name, string comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/AddEmployee", ReplyAction="http://tempuri.org/IEmployeeCreate/AddEmployeeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Client.ClientServiceReference.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeCreate/AddEmployeeEmployeeServiceFaultFault", Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
        void AddEmployee(Client.ClientServiceReference.EmployeeManagement employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/AddEmployee", ReplyAction="http://tempuri.org/IEmployeeCreate/AddEmployeeResponse")]
        System.Threading.Tasks.Task AddEmployeeAsync(Client.ClientServiceReference.EmployeeManagement employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/RemoveEmployee", ReplyAction="http://tempuri.org/IEmployeeCreate/RemoveEmployeeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Client.ClientServiceReference.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeCreate/RemoveEmployeeEmployeeServiceFaultFault", Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
        void RemoveEmployee(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/RemoveEmployee", ReplyAction="http://tempuri.org/IEmployeeCreate/RemoveEmployeeResponse")]
        System.Threading.Tasks.Task RemoveEmployeeAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/ModifyComment", ReplyAction="http://tempuri.org/IEmployeeCreate/ModifyCommentResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Client.ClientServiceReference.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeCreate/ModifyCommentEmployeeServiceFaultFault", Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
        Client.ClientServiceReference.EmployeeManagement ModifyComment(int id, string comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/ModifyComment", ReplyAction="http://tempuri.org/IEmployeeCreate/ModifyCommentResponse")]
        System.Threading.Tasks.Task<Client.ClientServiceReference.EmployeeManagement> ModifyCommentAsync(int id, string comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/ClearList", ReplyAction="http://tempuri.org/IEmployeeCreate/ClearListResponse")]
        void ClearList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/ClearList", ReplyAction="http://tempuri.org/IEmployeeCreate/ClearListResponse")]
        System.Threading.Tasks.Task ClearListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeCreateChannel : Client.ClientServiceReference.IEmployeeCreate, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeCreateClient : System.ServiceModel.ClientBase<Client.ClientServiceReference.IEmployeeCreate>, Client.ClientServiceReference.IEmployeeCreate {
        
        public EmployeeCreateClient() {
        }
        
        public EmployeeCreateClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeCreateClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeCreateClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeCreateClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client.ClientServiceReference.EmployeeManagement CreateEmployee(int id, string name, string comment) {
            return base.Channel.CreateEmployee(id, name, comment);
        }
        
        public System.Threading.Tasks.Task<Client.ClientServiceReference.EmployeeManagement> CreateEmployeeAsync(int id, string name, string comment) {
            return base.Channel.CreateEmployeeAsync(id, name, comment);
        }
        
        public void AddEmployee(Client.ClientServiceReference.EmployeeManagement employee) {
            base.Channel.AddEmployee(employee);
        }
        
        public System.Threading.Tasks.Task AddEmployeeAsync(Client.ClientServiceReference.EmployeeManagement employee) {
            return base.Channel.AddEmployeeAsync(employee);
        }
        
        public void RemoveEmployee(int id) {
            base.Channel.RemoveEmployee(id);
        }
        
        public System.Threading.Tasks.Task RemoveEmployeeAsync(int id) {
            return base.Channel.RemoveEmployeeAsync(id);
        }
        
        public Client.ClientServiceReference.EmployeeManagement ModifyComment(int id, string comment) {
            return base.Channel.ModifyComment(id, comment);
        }
        
        public System.Threading.Tasks.Task<Client.ClientServiceReference.EmployeeManagement> ModifyCommentAsync(int id, string comment) {
            return base.Channel.ModifyCommentAsync(id, comment);
        }
        
        public void ClearList() {
            base.Channel.ClearList();
        }
        
        public System.Threading.Tasks.Task ClearListAsync() {
            return base.Channel.ClearListAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClientServiceReference.IEmployeeRetrieve")]
    public interface IEmployeeRetrieve {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/GetById", ReplyAction="http://tempuri.org/IEmployeeRetrieve/GetByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Client.ClientServiceReference.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeRetrieve/GetByIdEmployeeServiceFaultFault", Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
        Client.ClientServiceReference.EmployeeManagement GetById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/GetById", ReplyAction="http://tempuri.org/IEmployeeRetrieve/GetByIdResponse")]
        System.Threading.Tasks.Task<Client.ClientServiceReference.EmployeeManagement> GetByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/GetByName", ReplyAction="http://tempuri.org/IEmployeeRetrieve/GetByNameResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Client.ClientServiceReference.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeRetrieve/GetByNameEmployeeServiceFaultFault", Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
        Client.ClientServiceReference.EmployeeManagement GetByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/GetByName", ReplyAction="http://tempuri.org/IEmployeeRetrieve/GetByNameResponse")]
        System.Threading.Tasks.Task<Client.ClientServiceReference.EmployeeManagement> GetByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/GetAllEmployee", ReplyAction="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Client.ClientServiceReference.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeeEmployeeServiceFaultFault", Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
        Client.ClientServiceReference.EmployeeManagement[] GetAllEmployee();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/GetAllEmployee", ReplyAction="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeeResponse")]
        System.Threading.Tasks.Task<Client.ClientServiceReference.EmployeeManagement[]> GetAllEmployeeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeeWithComment", ReplyAction="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeeWithCommentResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Client.ClientServiceReference.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeeWithCommentEmployeeServiceFaul" +
            "tFault", Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
        Client.ClientServiceReference.EmployeeManagement[] GetAllEmployeeWithComment();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeeWithComment", ReplyAction="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeeWithCommentResponse")]
        System.Threading.Tasks.Task<Client.ClientServiceReference.EmployeeManagement[]> GetAllEmployeeWithCommentAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeRetrieveChannel : Client.ClientServiceReference.IEmployeeRetrieve, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeRetrieveClient : System.ServiceModel.ClientBase<Client.ClientServiceReference.IEmployeeRetrieve>, Client.ClientServiceReference.IEmployeeRetrieve {
        
        public EmployeeRetrieveClient() {
        }
        
        public EmployeeRetrieveClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeRetrieveClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeRetrieveClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeRetrieveClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client.ClientServiceReference.EmployeeManagement GetById(int id) {
            return base.Channel.GetById(id);
        }
        
        public System.Threading.Tasks.Task<Client.ClientServiceReference.EmployeeManagement> GetByIdAsync(int id) {
            return base.Channel.GetByIdAsync(id);
        }
        
        public Client.ClientServiceReference.EmployeeManagement GetByName(string name) {
            return base.Channel.GetByName(name);
        }
        
        public System.Threading.Tasks.Task<Client.ClientServiceReference.EmployeeManagement> GetByNameAsync(string name) {
            return base.Channel.GetByNameAsync(name);
        }
        
        public Client.ClientServiceReference.EmployeeManagement[] GetAllEmployee() {
            return base.Channel.GetAllEmployee();
        }
        
        public System.Threading.Tasks.Task<Client.ClientServiceReference.EmployeeManagement[]> GetAllEmployeeAsync() {
            return base.Channel.GetAllEmployeeAsync();
        }
        
        public Client.ClientServiceReference.EmployeeManagement[] GetAllEmployeeWithComment() {
            return base.Channel.GetAllEmployeeWithComment();
        }
        
        public System.Threading.Tasks.Task<Client.ClientServiceReference.EmployeeManagement[]> GetAllEmployeeWithCommentAsync() {
            return base.Channel.GetAllEmployeeWithCommentAsync();
        }
    }
}
