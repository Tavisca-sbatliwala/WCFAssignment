using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeManagementSystem
{
    /// <summary>
    /// Defined Service Contract & Operation Contract for Create, Add, ModifyComment of Employee
    /// </summary>
    [ServiceContract]
    public interface IEmployeeCreate
    {
        
        [OperationContract]
        [FaultContract(typeof(EmployeeServiceFault))]
        EmployeeManagement CreateEmployee(int id,string name,string comment);
        
        [OperationContract]
        [FaultContract(typeof(EmployeeServiceFault))]
        void AddEmployee(EmployeeManagement emp);
        
        [OperationContract]
        [FaultContract(typeof(EmployeeServiceFault))]
        void RemoveEmployee(int id);
        
        [OperationContract]
        [FaultContract(typeof(EmployeeServiceFault))]
        EmployeeManagement ModifyComment(int id,string comment);
        
        [OperationContract]
        void ClearList();

    }
}
