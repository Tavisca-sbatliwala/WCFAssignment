using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementServiceLibrary
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class EmployeeService : IEmployeeAdd ,IEmployeeRemark
    {
        EmployeeManagement empObj = new EmployeeManagement();
        public static List<EmployeeManagement> list=new List<EmployeeManagement>();

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

        public EmployeeManagement GetEmployee(int id)
        {
            return list.Find(e => e.EmpID.Equals(id));
        }

        public EmployeeManagement CreateEmployee(int id, string name, string comments)
        {
            empObj.EmpID = id;
            empObj.EmpName = name;
            empObj.Comments = comments;
            empObj.TimeSubmitted = DateTime.Now;
            return empObj;
        }

        public EmployeeManagement GetEmployee(string name)
        {
            return list.Find(e => e.EmpName.Equals(name));
        }
    }
}
