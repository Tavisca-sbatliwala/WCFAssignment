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
        EmployeeManagement CreateEmployee(int id,string name,string comment);
        [OperationContract]
        void AddEmployee(EmployeeManagement emp);
        [OperationContract]
        void RemoveEmployee(int id);
        [OperationContract]
        EmployeeManagement ModifyRemark(int id,string comment);
        void ClearList();

    }
}
