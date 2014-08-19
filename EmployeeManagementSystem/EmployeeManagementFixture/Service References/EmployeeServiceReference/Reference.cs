﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeManagementFixture.EmployeeServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeServiceReference.IEmployeeCreate")]
    public interface IEmployeeCreate {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/CreateEmployee", ReplyAction="http://tempuri.org/IEmployeeCreate/CreateEmployeeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EmployeeManagementFixture.EmployeeServiceReference.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeCreate/CreateEmployeeEmployeeServiceFaultFault", Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
        EmployeeManagementSystem.EmployeeManagement CreateEmployee(int id, string name, string comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/CreateEmployee", ReplyAction="http://tempuri.org/IEmployeeCreate/CreateEmployeeResponse")]
        System.Threading.Tasks.Task<EmployeeManagementSystem.EmployeeManagement> CreateEmployeeAsync(int id, string name, string comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/AddEmployee", ReplyAction="http://tempuri.org/IEmployeeCreate/AddEmployeeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EmployeeManagementFixture.EmployeeServiceReference.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeCreate/AddEmployeeEmployeeServiceFaultFault", Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
        void AddEmployee(EmployeeManagementSystem.EmployeeManagement emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/AddEmployee", ReplyAction="http://tempuri.org/IEmployeeCreate/AddEmployeeResponse")]
        System.Threading.Tasks.Task AddEmployeeAsync(EmployeeManagementSystem.EmployeeManagement emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/RemoveEmployee", ReplyAction="http://tempuri.org/IEmployeeCreate/RemoveEmployeeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EmployeeManagementFixture.EmployeeServiceReference.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeCreate/RemoveEmployeeEmployeeServiceFaultFault", Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
        void RemoveEmployee(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/RemoveEmployee", ReplyAction="http://tempuri.org/IEmployeeCreate/RemoveEmployeeResponse")]
        System.Threading.Tasks.Task RemoveEmployeeAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/ModifyComment", ReplyAction="http://tempuri.org/IEmployeeCreate/ModifyCommentResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EmployeeManagementFixture.EmployeeServiceReference.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeCreate/ModifyCommentEmployeeServiceFaultFault", Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
        EmployeeManagementSystem.EmployeeManagement ModifyComment(int id, string comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/ModifyComment", ReplyAction="http://tempuri.org/IEmployeeCreate/ModifyCommentResponse")]
        System.Threading.Tasks.Task<EmployeeManagementSystem.EmployeeManagement> ModifyCommentAsync(int id, string comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/ClearList", ReplyAction="http://tempuri.org/IEmployeeCreate/ClearListResponse")]
        void ClearList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/ClearList", ReplyAction="http://tempuri.org/IEmployeeCreate/ClearListResponse")]
        System.Threading.Tasks.Task ClearListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeCreateChannel : EmployeeManagementFixture.EmployeeServiceReference.IEmployeeCreate, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeCreateClient : System.ServiceModel.ClientBase<EmployeeManagementFixture.EmployeeServiceReference.IEmployeeCreate>, EmployeeManagementFixture.EmployeeServiceReference.IEmployeeCreate {
        
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
        
        public EmployeeManagementSystem.EmployeeManagement CreateEmployee(int id, string name, string comment) {
            return base.Channel.CreateEmployee(id, name, comment);
        }
        
        public System.Threading.Tasks.Task<EmployeeManagementSystem.EmployeeManagement> CreateEmployeeAsync(int id, string name, string comment) {
            return base.Channel.CreateEmployeeAsync(id, name, comment);
        }
        
        public void AddEmployee(EmployeeManagementSystem.EmployeeManagement emp) {
            base.Channel.AddEmployee(emp);
        }
        
        public System.Threading.Tasks.Task AddEmployeeAsync(EmployeeManagementSystem.EmployeeManagement emp) {
            return base.Channel.AddEmployeeAsync(emp);
        }
        
        public void RemoveEmployee(int id) {
            base.Channel.RemoveEmployee(id);
        }
        
        public System.Threading.Tasks.Task RemoveEmployeeAsync(int id) {
            return base.Channel.RemoveEmployeeAsync(id);
        }
        
        public EmployeeManagementSystem.EmployeeManagement ModifyComment(int id, string comment) {
            return base.Channel.ModifyComment(id, comment);
        }
        
        public System.Threading.Tasks.Task<EmployeeManagementSystem.EmployeeManagement> ModifyCommentAsync(int id, string comment) {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeServiceReference.IEmployeeRetrieve")]
    public interface IEmployeeRetrieve {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/SearchById", ReplyAction="http://tempuri.org/IEmployeeRetrieve/SearchByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EmployeeManagementFixture.EmployeeServiceReference.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeRetrieve/SearchByIdEmployeeServiceFaultFault", Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
        EmployeeManagementSystem.EmployeeManagement SearchById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/SearchById", ReplyAction="http://tempuri.org/IEmployeeRetrieve/SearchByIdResponse")]
        System.Threading.Tasks.Task<EmployeeManagementSystem.EmployeeManagement> SearchByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/SearchByName", ReplyAction="http://tempuri.org/IEmployeeRetrieve/SearchByNameResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EmployeeManagementFixture.EmployeeServiceReference.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeRetrieve/SearchByNameEmployeeServiceFaultFault", Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
        EmployeeManagementSystem.EmployeeManagement SearchByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/SearchByName", ReplyAction="http://tempuri.org/IEmployeeRetrieve/SearchByNameResponse")]
        System.Threading.Tasks.Task<EmployeeManagementSystem.EmployeeManagement> SearchByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/GetAllEmployee", ReplyAction="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EmployeeManagementFixture.EmployeeServiceReference.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeeEmployeeServiceFaultFault", Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
        EmployeeManagementSystem.EmployeeManagement[] GetAllEmployee();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/GetAllEmployee", ReplyAction="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeeResponse")]
        System.Threading.Tasks.Task<EmployeeManagementSystem.EmployeeManagement[]> GetAllEmployeeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeeWithComment", ReplyAction="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeeWithCommentResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EmployeeManagementFixture.EmployeeServiceReference.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeeWithCommentEmployeeServiceFaul" +
            "tFault", Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
        EmployeeManagementSystem.EmployeeManagement[] GetAllEmployeeWithComment();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeeWithComment", ReplyAction="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeeWithCommentResponse")]
        System.Threading.Tasks.Task<EmployeeManagementSystem.EmployeeManagement[]> GetAllEmployeeWithCommentAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeRetrieveChannel : EmployeeManagementFixture.EmployeeServiceReference.IEmployeeRetrieve, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeRetrieveClient : System.ServiceModel.ClientBase<EmployeeManagementFixture.EmployeeServiceReference.IEmployeeRetrieve>, EmployeeManagementFixture.EmployeeServiceReference.IEmployeeRetrieve {
        
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
        
        public EmployeeManagementSystem.EmployeeManagement SearchById(int id) {
            return base.Channel.SearchById(id);
        }
        
        public System.Threading.Tasks.Task<EmployeeManagementSystem.EmployeeManagement> SearchByIdAsync(int id) {
            return base.Channel.SearchByIdAsync(id);
        }
        
        public EmployeeManagementSystem.EmployeeManagement SearchByName(string name) {
            return base.Channel.SearchByName(name);
        }
        
        public System.Threading.Tasks.Task<EmployeeManagementSystem.EmployeeManagement> SearchByNameAsync(string name) {
            return base.Channel.SearchByNameAsync(name);
        }
        
        public EmployeeManagementSystem.EmployeeManagement[] GetAllEmployee() {
            return base.Channel.GetAllEmployee();
        }
        
        public System.Threading.Tasks.Task<EmployeeManagementSystem.EmployeeManagement[]> GetAllEmployeeAsync() {
            return base.Channel.GetAllEmployeeAsync();
        }
        
        public EmployeeManagementSystem.EmployeeManagement[] GetAllEmployeeWithComment() {
            return base.Channel.GetAllEmployeeWithComment();
        }
        
        public System.Threading.Tasks.Task<EmployeeManagementSystem.EmployeeManagement[]> GetAllEmployeeWithCommentAsync() {
            return base.Channel.GetAllEmployeeWithCommentAsync();
        }
    }
}
