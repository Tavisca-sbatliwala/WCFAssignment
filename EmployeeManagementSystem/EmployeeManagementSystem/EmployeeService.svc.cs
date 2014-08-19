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
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class EmployeeService : IEmployeeCreate, IEmployeeRetrieve
    {
        EmployeeManagement empObj = new EmployeeManagement();
        private static List<EmployeeManagement> _emplist = new List<EmployeeManagement>();

        public void AddEmployee(EmployeeManagement emp)
        {
            _emplist.Add(emp);
        }

        public List<EmployeeManagement> GetAllEmployee()
        {
            EmployeeDoesNotExists fault = new EmployeeDoesNotExists();
            if (_emplist.Count() > 0)
            {
                return _emplist;
            }
            else
            {
                fault.FaultId = 100;
                fault.FaultMessage = "Employee Does not exits";
                fault.FaultDetail = "Employee is Not Present in the List";
                throw new FaultException<EmployeeDoesNotExists>(fault, "Employee Does not exits");
            }
        }

        public void RemoveEmployee(int id)
        {
            EmployeeDoesNotExists fault = new EmployeeDoesNotExists();
            if (_emplist.Any(e => e.EmpID == id))
            {
                _emplist.Remove(_emplist.Find(e => e.EmpID.Equals(id)));
            }
            else
            {
                fault.FaultId = 100;
                fault.FaultMessage = "Employee Does not exits";
                fault.FaultDetail = "Employee is Not Present in the List";
                throw new FaultException<EmployeeDoesNotExists>(fault, "Employee Does not exits");
            }

        }

        public EmployeeManagement GetEmployee(int id)
        {
            EmployeeDoesNotExists fault = new EmployeeDoesNotExists();
            if (_emplist.Any(e => e.EmpID == id))
            {
                return _emplist.Find(e => e.EmpID.Equals(id));
            }
            else
            {
                fault.FaultId = 100;
                fault.FaultMessage = "Employee Does not exits";
                fault.FaultDetail = "Employee is Not Present in the List";
                throw new FaultException<EmployeeDoesNotExists>(fault, "Employee Does not exits");
            }
        }

        public EmployeeManagement CreateEmployee(int id, string name, string comments)
        {
            EmployeeAlreadyExists fault = new EmployeeAlreadyExists();
            if (_emplist.Any(e => e.EmpID == id))
            {
                fault.FaultId = 101;
                fault.FaultMessage = "Employee Already Exists";
                fault.FaultDetail = "Employee Already Present in the List";
                throw new FaultException<EmployeeAlreadyExists>(fault, "Employee Already Exists");
            }
            else
            {
                empObj.EmpID = id;
                empObj.EmpName = name;
                empObj.Comment = comments;
                empObj.TimeSubmitted = DateTime.Now;
                return empObj;
            }
        }

        public EmployeeManagement GetEmployee(string name)
        { 
            EmployeeDoesNotExists fault = new EmployeeDoesNotExists();
            if (_emplist.Any(e => e.EmpName == name))
            {
                return _emplist.Find(e => e.EmpName.Equals(name));
            }
            else
            {
                fault.FaultId = 100;
                fault.FaultMessage = "Employee Does not exits";
                fault.FaultDetail = "Employee is Not Present in the List";
                throw new FaultException<EmployeeDoesNotExists>(fault, "Employee Does not exits");
            }
        }

        public EmployeeManagement ModifyComment(int id, string comment)
        {
            EmployeeDoesNotExists fault = new EmployeeDoesNotExists();
            if (_emplist.Any(e => e.EmpID == id))
            {
                var empToModify = _emplist.Find(e => e.EmpID.Equals(id));
                empToModify.Comment = comment;
                return empToModify;
            }
            else
            {
                fault.FaultId = 100;
                fault.FaultMessage = "Employee Does not exits";
                fault.FaultDetail = "Employee is Not Present in the List";
                throw new FaultException<EmployeeDoesNotExists>(fault, "Employee Does not exits");
            }
        }

        List<EmployeeManagement> IEmployeeRetrieve.GetAllEmployeeWithRemark()
        {
            EmployeeDoesNotExists fault = new EmployeeDoesNotExists();
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
                throw new FaultException<EmployeeDoesNotExists>(fault, "Employee Does not exits");
            }
        }
       
        public void ClearList()
        {
            _emplist.Clear();
        }
    }
}
