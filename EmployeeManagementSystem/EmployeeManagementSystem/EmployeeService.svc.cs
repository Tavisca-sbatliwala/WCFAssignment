using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeManagementSystem
{

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)] //singleton
    public class EmployeeService : IEmployeeCreate, IEmployeeRetrieve
    {
        EmployeeManagement empObj = new EmployeeManagement();
        /// <summary>
        /// Created List for Storing Employee details
        /// </summary>
        private static List<EmployeeManagement> _emplist = new List<EmployeeManagement>();

        /// <summary>
        /// It Add Employee Object in List
        /// </summary>
        /// <param name="emp">Employee Object</param>
        public void AddEmployee(EmployeeManagement emp)
        {
            _emplist.Add(emp);
        }

        /// <summary>
        /// It Return All the Employee in the List
        /// If Employee Does not Exist in the list, then it will throw FaultException
        /// </summary>
        /// <returns>List</returns>
        public List<EmployeeManagement> GetAllEmployee()
        {
            EmployeeServiceFault fault = new EmployeeServiceFault();
            if (_emplist.Count() > 0)
            {
                return _emplist;
            }
            else
            {
                fault.FaultId = 100;
                fault.FaultMessage = "Employee Does not exits";
                fault.FaultDetail = "Employee is Not Present in the List";
                throw new FaultException<EmployeeServiceFault>(fault, fault.FaultDetail);
            }
        }

        /// <summary>
        /// It Remove Employee Details from the List by using Employee Id
        /// If Employee Does not Exist in the list, then it will throw FaultException
        /// </summary>
        /// <param name="id">Employee ID</param>
        public void RemoveEmployee(int id)
        {
            EmployeeServiceFault fault = new EmployeeServiceFault();
            if (_emplist.Any(e => e.EmployeeID == id))
            {
                _emplist.Remove(_emplist.Find(e => e.EmployeeID.Equals(id)));
            }
            else
            {
                fault.FaultId = 100;
                fault.FaultMessage = "Employee Does not exits";
                fault.FaultDetail = "Employee is Not Present in the List";
                throw new FaultException<EmployeeServiceFault>(fault, fault.FaultDetail);
            }

        }
        /// <summary>
        /// It Retrieve Employee Details by using Employee ID
        /// If Employee Does not Exist in the list, then it will throw FaultException
        /// </summary>
        /// <param name="id">Employee ID</param>
        /// <returns>Employee Object</returns>

        public EmployeeManagement GetEmployee(int id)
        {
            EmployeeServiceFault fault = new EmployeeServiceFault();
            if (_emplist.Any(e => e.EmployeeID == id))
            {
                return _emplist.Find(e => e.EmployeeID.Equals(id));
            }
            else
            {
                fault.FaultId = 100;
                fault.FaultMessage = "Employee Does not exits";
                fault.FaultDetail = "Employee is Not Present in the List";
                throw new FaultException<EmployeeServiceFault>(fault, fault.FaultDetail);
            }
        }
        /// <summary>
        /// It create Employee Object
        /// If Employee Already Exist in the list, then it will throw FaultException
        /// </summary>
        /// <param name="id">Employee Id</param>
        /// <param name="name">Employee Name</param>
        /// <param name="comment">Employee Comment</param>
        /// <returns>Employee Object</returns>

        public EmployeeManagement CreateEmployee(int id, string name, string comment)
        {
            EmployeeServiceFault fault = new EmployeeServiceFault();
            if (_emplist.Any(e => e.EmployeeID == id))
            {
                fault.FaultId = 101;
                fault.FaultMessage = "Employee Already Exists";
                fault.FaultDetail = "Employee Already Present in the List";
                throw new FaultException<EmployeeServiceFault>(fault, "Employee Already Exists");
            }
            else
            {
                empObj.EmployeeID = id;
                empObj.EmployeeName = name;
                empObj.Comment = comment;
                empObj.TimeSubmitted = DateTime.Now;
                return empObj;
            }
        }

        /// <summary>
        /// It Retrieve Employee Details by using Employee Name
        /// If Employee Does not Exist in the list, then it will throw FaultException
        /// </summary>
        /// <param name="name">Employee Name</param>
        /// <returns>Employee Object</returns>
        public EmployeeManagement GetEmployee(string name)
        {
            EmployeeServiceFault fault = new EmployeeServiceFault();
            if (_emplist.Any(e => e.EmployeeName == name))
            {
                return _emplist.Find(e => e.EmployeeName.Equals(name));
            }
            else
            {
                fault.FaultId = 100;
                fault.FaultMessage = "Employee Does not exits";
                fault.FaultDetail = "Employee is Not Present in the List";
                throw new FaultException<EmployeeServiceFault>(fault, fault.FaultDetail);
            }
        }

        /// <summary>
        /// It Modify Comment of Already Existing Employee
        /// If Employee Does not Exist in the list, then it will throw FaultException
        /// </summary>
        /// <param name="id">Employee ID</param>
        /// <param name="comment">Employee Comment</param>
        /// <returns>Employee Object</returns>
        public EmployeeManagement ModifyComment(int id, string comment)
        {
            EmployeeServiceFault fault = new EmployeeServiceFault();
            if (_emplist.Any(e => e.EmployeeID == id))
            {
                var empToModify = _emplist.Find(e => e.EmployeeID.Equals(id));
                empToModify.Comment = comment;
                return empToModify;
            }
            else
            {
                fault.FaultId = 100;
                fault.FaultMessage = "Employee Does not exits";
                fault.FaultDetail = "Employee is Not Present in the List";
                throw new FaultException<EmployeeServiceFault>(fault, fault.FaultDetail);
            }
        }
        /// <summary>
        /// It Retrieve Employee Details of Employee Who has Comment/Remark
        /// If Employee Does not Exist in the list, then it will throw FaultException
        /// </summary>
        /// <returns></returns>
        List<EmployeeManagement> IEmployeeRetrieve.GetAllEmployeeWithComment()
        {
            EmployeeServiceFault fault = new EmployeeServiceFault();
            var selectedEmployee = _emplist.FindAll(e => e.Comment != null);
            if (selectedEmployee.Count() > 0)
            {
                return _emplist.FindAll(e => e.Comment != null);
            }
            else
            {
                fault.FaultId = 100;
                fault.FaultMessage = "Employee Does not exits";
                fault.FaultDetail = "Employee is Not Present in the List";
                throw new FaultException<EmployeeServiceFault>(fault, fault.FaultDetail);
            }
        }
        /// <summary>
        /// It clear the EmployeeList
        /// </summary>

        public void ClearList()
        {
            _emplist.Clear();
        }
    }
}
