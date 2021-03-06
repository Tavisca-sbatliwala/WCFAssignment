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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeServiceReference.IEmployeeCreate")]
    public interface IEmployeeCreate {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/CreateEmployee", ReplyAction="http://tempuri.org/IEmployeeCreate/CreateEmployeeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EmployeeManagementSystem.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeCreate/CreateEmployeeEmployeeServiceFaultFault", Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
        EmployeeManagementSystem.EmployeeManagement CreateEmployee(int id, string name, string comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/CreateEmployee", ReplyAction="http://tempuri.org/IEmployeeCreate/CreateEmployeeResponse")]
        System.Threading.Tasks.Task<EmployeeManagementSystem.EmployeeManagement> CreateEmployeeAsync(int id, string name, string comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/AddEmployee", ReplyAction="http://tempuri.org/IEmployeeCreate/AddEmployeeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EmployeeManagementSystem.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeCreate/AddEmployeeEmployeeServiceFaultFault", Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
        void AddEmployee(EmployeeManagementSystem.EmployeeManagement employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/AddEmployee", ReplyAction="http://tempuri.org/IEmployeeCreate/AddEmployeeResponse")]
        System.Threading.Tasks.Task AddEmployeeAsync(EmployeeManagementSystem.EmployeeManagement employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/RemoveEmployee", ReplyAction="http://tempuri.org/IEmployeeCreate/RemoveEmployeeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EmployeeManagementSystem.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeCreate/RemoveEmployeeEmployeeServiceFaultFault", Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
        void RemoveEmployee(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/RemoveEmployee", ReplyAction="http://tempuri.org/IEmployeeCreate/RemoveEmployeeResponse")]
        System.Threading.Tasks.Task RemoveEmployeeAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeCreate/ModifyComment", ReplyAction="http://tempuri.org/IEmployeeCreate/ModifyCommentResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EmployeeManagementSystem.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeCreate/ModifyCommentEmployeeServiceFaultFault", Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
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
        
        public void AddEmployee(EmployeeManagementSystem.EmployeeManagement employee) {
            base.Channel.AddEmployee(employee);
        }
        
        public System.Threading.Tasks.Task AddEmployeeAsync(EmployeeManagementSystem.EmployeeManagement employee) {
            return base.Channel.AddEmployeeAsync(employee);
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/GetById", ReplyAction="http://tempuri.org/IEmployeeRetrieve/GetByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EmployeeManagementSystem.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeRetrieve/GetByIdEmployeeServiceFaultFault", Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
        EmployeeManagementSystem.EmployeeManagement GetById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/GetById", ReplyAction="http://tempuri.org/IEmployeeRetrieve/GetByIdResponse")]
        System.Threading.Tasks.Task<EmployeeManagementSystem.EmployeeManagement> GetByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/GetByName", ReplyAction="http://tempuri.org/IEmployeeRetrieve/GetByNameResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EmployeeManagementSystem.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeRetrieve/GetByNameEmployeeServiceFaultFault", Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
        EmployeeManagementSystem.EmployeeManagement GetByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/GetByName", ReplyAction="http://tempuri.org/IEmployeeRetrieve/GetByNameResponse")]
        System.Threading.Tasks.Task<EmployeeManagementSystem.EmployeeManagement> GetByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/GetAllEmployee", ReplyAction="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EmployeeManagementSystem.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeeEmployeeServiceFaultFault", Name="EmployeeServiceFault", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementSystem")]
        EmployeeManagementSystem.EmployeeManagement[] GetAllEmployee();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/GetAllEmployee", ReplyAction="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeeResponse")]
        System.Threading.Tasks.Task<EmployeeManagementSystem.EmployeeManagement[]> GetAllEmployeeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeeWithComment", ReplyAction="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeeWithCommentResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EmployeeManagementSystem.EmployeeServiceFault), Action="http://tempuri.org/IEmployeeRetrieve/GetAllEmployeeWithCommentEmployeeServiceFaul" +
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
        
        public EmployeeManagementSystem.EmployeeManagement GetById(int id) {
            return base.Channel.GetById(id);
        }
        
        public System.Threading.Tasks.Task<EmployeeManagementSystem.EmployeeManagement> GetByIdAsync(int id) {
            return base.Channel.GetByIdAsync(id);
        }
        
        public EmployeeManagementSystem.EmployeeManagement GetByName(string name) {
            return base.Channel.GetByName(name);
        }
        
        public System.Threading.Tasks.Task<EmployeeManagementSystem.EmployeeManagement> GetByNameAsync(string name) {
            return base.Channel.GetByNameAsync(name);
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
