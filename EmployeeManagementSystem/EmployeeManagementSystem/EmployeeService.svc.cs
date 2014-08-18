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
        public static List<EmployeeManagement> _emplist = new List<EmployeeManagement>();

        public void AddEmployee(EmployeeManagement emp)
        {
            _emplist.Add(emp);
        }

        public List<EmployeeManagement> GetAllEmployee()
        {
            return _emplist;
        }

        public void RemoveEmployee(int id)
        {
            _emplist.Remove(_emplist.Find(e => e.EmpID.Equals(id)));
        }

        public EmployeeManagement GetEmployee(int id)
        {
            return _emplist.Find(e => e.EmpID.Equals(id));
        }

        public EmployeeManagement CreateEmployee(int id, string name, string comments)
        {

            empObj.EmpID = id;
            empObj.EmpName = name;
            empObj.Comment = comments;
            empObj.TimeSubmitted = DateTime.Now;
            return empObj;
        }

        public EmployeeManagement GetEmployee(string name)
        {
            return _emplist.Find(e => e.EmpName.Equals(name));
        }


        public EmployeeManagement ModifyRemark(int id,string comment)
        {
            var tempEmp = _emplist.Find(e => e.EmpID.Equals(id));
            if (tempEmp == null)
            {
                throw FaultException.CreateFault(MessageFault.CreateFault(new FaultCode("100"), "Employee does not exist"));
            }
            else
            {
                tempEmp.Comment = comment;
                return tempEmp;
            }
        }

        List<EmployeeManagement> IEmployeeRetrieve.GetAllEmployeeWithRemark()
        {
            return _emplist.FindAll(e => e.Comment != null);
        }


        public void ClearList()
        {
            var count=_emplist.Count();
            _emplist.RemoveRange(0, count);
        }
    }
}
