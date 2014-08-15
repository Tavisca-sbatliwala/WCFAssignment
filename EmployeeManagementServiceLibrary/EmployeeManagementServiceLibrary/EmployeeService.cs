using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementServiceLibrary
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class EmployeeService : IEmployeeAdd
    {
        EmployeeManagement empObj = new EmployeeManagement();
        List<EmployeeManagement> list=new List<EmployeeManagement>();

        public void AddEmployee(EmployeeManagement emp)
        {
            list.Add(emp);
        }

        public List<EmployeeManagement> GetAllEmployee()
        {
            return list;
        }

        public void RemoveEmployee(string id)
        {
            list.Remove(list.Find(e => e.EmpID.Equals(id)));
        }


        public EmployeeManagement GetEmployee(string id)
        {
            return list.Find(e => e.EmpID.Equals(id));
        }

        public EmployeeManagement CreateEmployee(string id, string name, string comments)
        {
            empObj.EmpID = id;
            empObj.EmpName = name;
            empObj.Comments = comments;
            empObj.TimeSubmitted = DateTime.Now;
            return empObj;
        }
    }
}
