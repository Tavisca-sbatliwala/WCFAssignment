using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    [ServiceContract]
    public interface IEmployeeRetrieve
    {
        [OperationContract(Name = "SearchById")]
        EmployeeManagement GetEmployee(int id);
        [OperationContract(Name = "SearchByName")]
        EmployeeManagement GetEmployee(string name);
        [OperationContract]
        List<EmployeeManagement> GetAllEmployee();
        [OperationContract]
        List<EmployeeManagement> GetAllEmployeeWithRemark();
    }
}