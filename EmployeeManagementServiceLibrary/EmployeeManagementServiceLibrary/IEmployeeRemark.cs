using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementServiceLibrary
{
    [ServiceContract]
    public interface IEmployeeRemark
    {
        [OperationContract(Name = "SearchById")]
        EmployeeManagement GetEmployee(int id);
        
        [OperationContract(Name = "SearchByName")]
        EmployeeManagement GetEmployee(string name);
        [OperationContract]
        List<EmployeeManagement> GetAllEmployee();
    }
}
