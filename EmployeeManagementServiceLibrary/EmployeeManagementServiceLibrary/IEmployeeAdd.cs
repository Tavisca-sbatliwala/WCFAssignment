using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementServiceLibrary
{
    [ServiceContract]
    public interface IEmployeeAdd
    {
        [OperationContract]
        EmployeeManagement CreateEmployee(string id,string name,string comments);
        [OperationContract]
        void AddEmployee(EmployeeManagement emp);
        [OperationContract]
        void RemoveEmployee(string id);
        [OperationContract (Name="SearchById")]
        EmployeeManagement GetEmployee(string id);
        [OperationContract (Name="SearchByName")]
        EmployeeManagement GetEmployee(string name);
        [OperationContract]
        List<EmployeeManagement> GetAllEmployee();
    }
}
