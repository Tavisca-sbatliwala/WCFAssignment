using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementServiceLibrary
{
    [ServiceContract]
    public interface IEmployeeCreate
    {
        [OperationContract]
        EmployeeManagement CreateEmployee(int id,string name,string comments);
        [OperationContract]
        void AddEmployee(EmployeeManagement emp);
        [OperationContract]
        void RemoveEmployee(int id);
        [OperationContract]
        void ModifyDetails(int id);
        
    }
}
