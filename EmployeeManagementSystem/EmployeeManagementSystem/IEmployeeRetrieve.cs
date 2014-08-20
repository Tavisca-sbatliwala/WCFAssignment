using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    /// <summary>
    /// Defined Service Contract & Operation Contract for Retrieving Employee Details 
    /// </summary>
    [ServiceContract]
    public interface IEmployeeRetrieve
    {
        /// <summary>
        /// It Retrieve Employee Detail By using Employee ID  
        /// </summary>
        /// <param name="id">Employee ID</param>
        /// <returns>Object of EmployeeManagement</returns>

        [OperationContract(Name = "GetById")]
        [FaultContract(typeof(EmployeeServiceFault))]
        EmployeeManagement GetEmployee(int id);
        /// <summary>
        /// It Retrieve Employee Detail By using Employee Name
        /// </summary>
        /// <param name="name">Employee Name</param>
        /// <returns>Object of EmployeeManagement</returns>
        
        [OperationContract(Name = "GetByName")]
        [FaultContract(typeof(EmployeeServiceFault))]
        EmployeeManagement GetEmployee(string name);
        
        /// <summary>
        /// It retrieve Employee Details of all the Employee in the List
        /// </summary>
        /// <returns>List</returns>
       
        [OperationContract]
        [FaultContract(typeof(EmployeeServiceFault))]
        List<EmployeeManagement> GetAllEmployee();
        
        /// <summary>
        /// It retrieve Employees those have Comment/Remark
        /// </summary>
        /// <returns>List</returns>
        
        [OperationContract]
        [FaultContract(typeof(EmployeeServiceFault))]
        List<EmployeeManagement> GetAllEmployeeWithComment();
    }
}