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

            EmployeeCreateClient clientCreate = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate");
            EmployeeRetrieveClient clientRetrive = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve");
            EmployeeManagement empObj = new EmployeeManagement();
            int choice;
            string ch = " ";
            do
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Employee Management Service");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1. Create & Add New Employee");
                Console.WriteLine("2. Modify Employee Details");
                Console.WriteLine("3. Get Employee Details by Name");
                Console.WriteLine("4. Get Employee Details by ID");
                Console.WriteLine("5. Get List of All Employee");
                Console.WriteLine("6. Remove Employee From List");

                choice = Int32.Parse(Console.ReadLine());
                //Console.WriteLine(choice);

                switch (choice)
                {
                    case 1:

                        Console.WriteLine("Enter Employee ID : ");
                        var empId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name : ");
                        var empName = Console.ReadLine();
                        Console.WriteLine("Enter Employee comment : ");
                        var comment = Console.ReadLine();
                        var emp = clientCreate.CreateEmployee(empId, empName, comment);
                        clientCreate.AddEmployee(emp);
                        Console.WriteLine("Employee Details Added Successfully...");
                        break;

                    case 2:
                        break;

                    case 3:
                        Console.WriteLine("Enter Name of Employee to Get Employee Details : ");
                        var name = Console.ReadLine();
                        var getEmp = clientRetrive.SearchByName(name);
                        Console.WriteLine(getEmp.EmpID + " " + getEmp.EmpName + " " + getEmp.Comments + " " + getEmp.TimeSubmitted);
                        Console.WriteLine("Employee Details Found...");
                        break;

                    case 4:
                        Console.WriteLine("Enter Employee Id to Search Employee : ");
                        var id = int.Parse(Console.ReadLine());
                        var getEmp1 = clientRetrive.SearchById(id);
                        Console.WriteLine(getEmp1.EmpID + " " + getEmp1.EmpName + " " + getEmp1.Comments + " " + getEmp1.TimeSubmitted);
                        Console.WriteLine("Employee Details Found...");
                        break;

                    case 5:
                        EmployeeManagement[] employee = clientRetrive.GetAllEmployee();

                        foreach (EmployeeManagement em in employee)
                        {
                            Console.WriteLine(em.EmpID + " " + em.EmpName + " " + em.Comments + " " + em.TimeSubmitted);
                        }

                        break;

                    case 6:
                        Console.WriteLine("Enter Employee Id to Remove Its Details : ");
                        var removeId = int.Parse(Console.ReadLine());
                        clientCreate.RemoveEmployee(removeId);
                        Console.WriteLine("Employee Details Removed Successfully...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice..");
                        break;

                }

                Console.WriteLine("Do You Want To Continue(y/n) : ");
                ch = Console.ReadLine();


            } while (ch.Equals("Y") || ch.Equals("y"));



            ////empObj.Comments = "Hello Saif";
            ////empObj.EmpName = "Saifuddin";
            ////empObj.EmpID = 100;
            ////empObj.TimeSubmitted = DateTime.Now;
            ////clientCreate.AddEmployee(empObj);

            ////Console.WriteLine("Enter Employee ID : ");
            ////var empId = int.Parse(Console.ReadLine());
            ////Console.WriteLine("Enter Employee Name : ");
            ////var empName = Console.ReadLine();
            ////Console.WriteLine("Enter Employee comment : ");
            ////var comment = Console.ReadLine();
            ////var emp = clientCreate.CreateEmployee(empId, empName, comment);
            ////clientCreate.AddEmployee(emp);





            ////Console.WriteLine(getEmp);
            //Console.ReadLine();

        }
    }
}

