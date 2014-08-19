using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeManagementSystem
{
    [ServiceContract]
    public interface IEmployeeCreate
    {
        [OperationContract]
        [FaultContract(typeof(EmployeeAlreadyExists))]
        EmployeeManagement CreateEmployee(int id,string name,string comment);
        
        [OperationContract]
        [FaultContract(typeof(EmployeeAlreadyExists))]
        void AddEmployee(EmployeeManagement emp);
        
        [OperationContract]
        [FaultContract(typeof(EmployeeDoesNotExists))]
        void RemoveEmployee(int id);
        
        [OperationContract]
        [FaultContract(typeof(EmployeeDoesNotExists))]
        EmployeeManagement ModifyComment(int id,string comment);
        
        [OperationContract]
        void ClearList();

    }
}
