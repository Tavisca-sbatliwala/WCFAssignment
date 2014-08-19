using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ClientServiceReference;
using System.ServiceModel;
namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client is Running..........");

            EmployeeCreateClient _clientcreate = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate");
            EmployeeRetrieveClient _clientretrive = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve");
            int choice;
            string ch = " ";
            do
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Employee Management Service");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1. Create & Add New Employee");
                Console.WriteLine("2. Modify Comment of Employee");
                Console.WriteLine("3. Get Employee Details by Name");
                Console.WriteLine("4. Get Employee Details by ID");
                Console.WriteLine("5. Get List of All Employee");
                Console.WriteLine("6. Remove Employee From List");
                Console.WriteLine("---------------------------------------");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Enter Employee ID : ");
                            var empId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Employee Name : ");
                            var empName = Console.ReadLine();
                            Console.WriteLine("Enter Employee comment : ");
                            var comment = Console.ReadLine();
                            var emp = _clientcreate.CreateEmployee(empId, empName, comment);
                            _clientcreate.AddEmployee(emp);
                            Console.WriteLine("Employee Details Added Successfully...");
                        }
                        catch (FaultException<EmployeeServiceFault> ex)
                        {
                            Console.WriteLine("FaultId::" + ex.Detail.FaultId);
                            Console.WriteLine("FaultMessage::" + ex.Detail.FaultMessage + Environment.NewLine);
                            Console.WriteLine("FaultDetails::" + Environment.NewLine + ex.Detail.FaultDetail);
                        }

                        break;

                    case 2:
                        try
                        {
                            Console.WriteLine("Enter Employee Id to Add/Modify Comment : ");
                            var id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Comment ");
                            var modifyComment = Console.ReadLine();
                            _clientcreate.ModifyComment(id, modifyComment);
                            Console.WriteLine("Comment modified/Added Successfully..");
                        }
                        catch (FaultException<EmployeeServiceFault> ex)
                        {
                            Console.WriteLine("FaultId::" + ex.Detail.FaultId);
                            Console.WriteLine("FaultMessage::" + ex.Detail.FaultMessage + Environment.NewLine);
                            Console.WriteLine("FaultDetails::" + Environment.NewLine + ex.Detail.FaultDetail);
                        }

                        break;

                    case 3:
                        try
                        {
                            Console.WriteLine("Enter Name of Employee to Get Employee Details : ");
                            var name = Console.ReadLine();
                            var getEmp = _clientretrive.SearchByName(name);
                            Console.WriteLine(getEmp.EmpID + " " + getEmp.EmpName + " " + getEmp.Comment + " " + getEmp.TimeSubmitted);
                            Console.WriteLine("Employee Details Found...");
                        }
                        catch (FaultException<EmployeeServiceFault> ex)
                        {
                            Console.WriteLine("FaultId::" + ex.Detail.FaultId);
                            Console.WriteLine("FaultMessage::" + ex.Detail.FaultMessage + Environment.NewLine);
                            Console.WriteLine("FaultDetails::" + Environment.NewLine + ex.Detail.FaultDetail);
                        }

                        break;

                    case 4:
                        try
                        {
                            Console.WriteLine("Enter Employee Id to Search Employee : ");
                            var searchId = int.Parse(Console.ReadLine());
                            var getEmp1 = _clientretrive.SearchById(searchId);
                            Console.WriteLine(getEmp1.EmpID + " " + getEmp1.EmpName + " " + getEmp1.Comment + " " + getEmp1.TimeSubmitted);
                            Console.WriteLine("Employee Details Found...");
                        }
                        catch (FaultException<EmployeeServiceFault> ex)
                        {
                            Console.WriteLine("FaultId::" + ex.Detail.FaultId);
                            Console.WriteLine("FaultMessage::" + ex.Detail.FaultMessage + Environment.NewLine);
                            Console.WriteLine("FaultDetails::" + Environment.NewLine + ex.Detail.FaultDetail);
                        }

                        break;

                    case 5:
                        try
                        {

                            EmployeeManagement[] employee = _clientretrive.GetAllEmployee();

                            foreach (EmployeeManagement em in employee)
                            {
                                Console.WriteLine(em.EmpID + " " + em.EmpName + " " + em.Comment + " " + em.TimeSubmitted);
                            }
                        }
                        catch (FaultException<EmployeeServiceFault> ex)
                        {
                            Console.WriteLine("FaultId::" + ex.Detail.FaultId);
                            Console.WriteLine("FaultMessage::" + ex.Detail.FaultMessage + Environment.NewLine);
                            Console.WriteLine("FaultDetails::" + Environment.NewLine + ex.Detail.FaultDetail);
                        }

                        break;

                    case 6:
                        try
                        {
                            Console.WriteLine("Enter Employee Id to Remove Its Details : ");
                            var removeId = int.Parse(Console.ReadLine());
                            _clientcreate.RemoveEmployee(removeId);
                            Console.WriteLine("Employee Details Removed Successfully...");
                        }
                        catch (FaultException<EmployeeServiceFault> ex)
                        {
                            Console.WriteLine("FaultId::" + ex.Detail.FaultId);
                            Console.WriteLine("FaultMessage::" + ex.Detail.FaultMessage + Environment.NewLine);
                            Console.WriteLine("FaultDetails::" + Environment.NewLine + ex.Detail.FaultDetail);
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid Choice..");
                        break;

                }

                Console.WriteLine("Do You Want To Continue(y/n) : ");
                ch = Console.ReadLine();


            } while (ch.Equals("Y") || ch.Equals("y"));


        }
    }
}

