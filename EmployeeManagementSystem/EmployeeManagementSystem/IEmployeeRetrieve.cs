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
        [FaultContract(typeof(EmployeeDoesNotExists))]
        EmployeeManagement GetEmployee(int id);
        
        [OperationContract(Name = "SearchByName")]
        [FaultContract(typeof(EmployeeDoesNotExists))]
        EmployeeManagement GetEmployee(string name);
        
        [OperationContract]
        [FaultContract(typeof(EmployeeDoesNotExists))]
        List<EmployeeManagement> GetAllEmployee();
        
        [OperationContract]
        [FaultContract(typeof(EmployeeDoesNotExists))]
        List<EmployeeManagement> GetAllEmployeeWithRemark();
    }
}