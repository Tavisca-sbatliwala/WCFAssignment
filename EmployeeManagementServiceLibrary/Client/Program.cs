using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ClientServiceReference;
namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client is Running..........");
           
            EmployeeAddClient client = new EmployeeAddClient("BasicHttpBinding_IEmployeeAdd");
            EmployeeManagement empObj = new EmployeeManagement();
            empObj.Comments = "Hello Saif";
            empObj.EmpName = "Saifuddin";
            empObj.EmpID = "100";
            empObj.TimeSubmitted = DateTime.Now;
            client.AddEmployee(empObj);

            Console.WriteLine("Enter Employee ID : ");
            var empId=Console.ReadLine();
            Console.WriteLine("Enter Employee Name : ");
            var empName=Console.ReadLine();
            Console.WriteLine("Enter Employee comment : ");
            var comment=Console.ReadLine();
            var emp=client.CreateEmployee(empId, empName, comment);
            client.AddEmployee(emp);


            EmployeeManagement[] employee = client.GetAllEmployee();

            foreach (EmployeeManagement em in employee)
            {
                Console.WriteLine(em.EmpID + " " + em.EmpName + " " + em.Comments + " " + em.TimeSubmitted);
            }


            Console.WriteLine("Enter Employee Id to Search Employee : ");
            var id=Console.ReadLine();
            var getEmp=client.GetEmployee(id);
            Console.WriteLine(getEmp.EmpID + " " + getEmp.EmpName + " " + getEmp.Comments + " " + getEmp.TimeSubmitted);
            //Console.WriteLine(getEmp);
            Console.ReadLine();

        }
    }
}
