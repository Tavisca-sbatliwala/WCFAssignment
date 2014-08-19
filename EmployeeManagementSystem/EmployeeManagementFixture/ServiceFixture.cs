using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagementFixture.EmployeeServiceReference;
using EmployeeManagementSystem;
using System.ServiceModel;

namespace EmployeeManagementFixture
{

    /// <summary>
    /// Specifications
    /// 1.Add and Retrieve
    /// 2.Add it again
    /// 3.Add remark for existing employee
    /// 4.Add remark where employee is not present in memory object(database)
    /// 5.Retrieve employee who has remarks
    /// 6.Add employee with incorrect request
    /// 7.Retrieve employee list
    /// 8.Retrieve employee by name
    /// </summary>

    [TestClass]
    public class ServiceFixture
    {
        /// <summary>
        /// It Clear the Employee List Before Running Each Test Cases
        /// </summary>
        [TestInitialize]
        public void CleanUpList()
        {
            var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate");
            createClient.ClearList();
        }

        /// <summary>
        /// Test case for Adding Employee Details in the List & Retrieving Details
        /// </summary>
        [TestMethod]
        public void AddAndRetrieveEmployeeDetails()
        {
            var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate");
            var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve");

            var emp = createClient.CreateEmployee(1, "saif", "Hello..");
            createClient.AddEmployee(emp);

            var empDetails = retrieveClient.SearchById(1);
            Assert.AreEqual(1, empDetails.EmpID);
            Assert.AreEqual("saif", empDetails.EmpName);
            Assert.AreEqual("Hello..", empDetails.Comment);
        }

   
        [TestMethod]
        public void AddAgainEmployeeDetails()
        {
            var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate");
            var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve");

            var emp = createClient.CreateEmployee(2, "saifuddin", "Hello..Again..");
            createClient.AddEmployee(emp);

            var empTwo = createClient.CreateEmployee(1, "saif", "Hello..");
            createClient.AddEmployee(empTwo);

            var empOneDetails = retrieveClient.SearchById(1);
            Assert.AreEqual(1, empOneDetails.EmpID);
            Assert.AreEqual("saif", empOneDetails.EmpName);
            Assert.AreEqual("Hello..", empOneDetails.Comment);

            var empTwoDetails = retrieveClient.SearchById(2);
            Assert.AreEqual(2, empTwoDetails.EmpID);
            Assert.AreEqual("saifuddin", empTwoDetails.EmpName);
            Assert.AreEqual("Hello..Again..", empTwoDetails.Comment);
        }

        /// <summary>
        /// Test Case for Adding Comment/Remark for Existing Employee in the List
        /// </summary>
        [TestMethod]
        public void AddCommentForExistingEmployee()
        {
            var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate");
            var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve");

            var emp = createClient.CreateEmployee(1, "saif", "Hello..");
            createClient.AddEmployee(emp);

            var empModified = createClient.ModifyComment(1, "Modified Hello...");
            Assert.AreEqual(1, empModified.EmpID);
            Assert.AreEqual("saif", empModified.EmpName);
            Assert.AreEqual("Modified Hello...", empModified.Comment);

        }
        /// <summary>
        /// Test Case for Retrieving Details of Employee , if there Comment is not null
        /// </summary>

        [TestMethod]
        public void GetAllEmployeeWithComment()
        {
            var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate");
            var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve");

            var emp = createClient.CreateEmployee(2, "saifuddin", "Hello..Again..");
            createClient.AddEmployee(emp);

            var empTwo = createClient.CreateEmployee(1, "saif", "Hello..");
            createClient.AddEmployee(empTwo);

            var empThree = createClient.CreateEmployee(3, "saifBatliwala", null);
            createClient.AddEmployee(empThree);

            var empFour = createClient.CreateEmployee(4, "Batliwala", null);
            createClient.AddEmployee(empFour);

            EmployeeManagement[] employee = retrieveClient.GetAllEmployeeWithComment();
            Assert.AreEqual(2, employee.Length);
        }

        /// <summary>
        /// Test Case for Retrieving Details of all the Employee
        /// </summary>
        [TestMethod]
        public void GetAllEmployee()
        {
            var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate");
            var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve");

            var emp = createClient.CreateEmployee(2, "saifuddin", "Hello..Again..");
            createClient.AddEmployee(emp);

            var empTwo = createClient.CreateEmployee(1, "saif", "Hello..");
            createClient.AddEmployee(empTwo);

            var empThree = createClient.CreateEmployee(3, "saifBatliwala", null);
            createClient.AddEmployee(empThree);

            var empFour = createClient.CreateEmployee(4, "Batliwala", null);
            createClient.AddEmployee(empFour);

            EmployeeManagement[] employee = retrieveClient.GetAllEmployee();
            Assert.AreEqual(4, employee.Length);
        }

        /// <summary>
        /// Test Case for Retrieving Details of Employee by using Employee Name
        /// </summary>
        [TestMethod]
        public void RetrieveEmployeeByName()
        {
            var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate");
            var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve");

            var emp = createClient.CreateEmployee(2, "saifuddin", "Hello..Again..");
            createClient.AddEmployee(emp);

            var empTwo = createClient.CreateEmployee(1, "saif", "Hello..");
            createClient.AddEmployee(empTwo);

            var result = retrieveClient.SearchByName("saif");
            Assert.AreEqual(1, result.EmpID);
            Assert.AreEqual("saif", result.EmpName);
            Assert.AreEqual("Hello..", result.Comment);
        }
        /// <summary>
        /// Test Case for Retrieving Details of Employee by using Employee ID
        /// </summary>

        [TestMethod]
        public void RetrieveEmployeeByID()
        {
            var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate");
            var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve");

            var emp = createClient.CreateEmployee(2, "saifuddin", "Hello..Again..");
            createClient.AddEmployee(emp);

            var empTwo = createClient.CreateEmployee(1, "saif", "Hello..");
            createClient.AddEmployee(empTwo);

            var result = retrieveClient.SearchById(2);
            Assert.AreEqual(2, result.EmpID);
            Assert.AreEqual("saifuddin", result.EmpName);
            Assert.AreEqual("Hello..Again..", result.Comment);
        }

        /// <summary>
        /// Test Case for Removing Details of Employee by using Employee ID
        /// </summary>

        [TestMethod]
        public void RemoveEmployeeById()
        {
            var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate");
            var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve");

            var emp = createClient.CreateEmployee(2, "saifuddin", "Hello..Again..");
            createClient.AddEmployee(emp);

            var empTwo = createClient.CreateEmployee(1, "saif", "Hello..");
            createClient.AddEmployee(empTwo);

            createClient.RemoveEmployee(1);
            EmployeeManagement[] employee = retrieveClient.GetAllEmployee();
            Assert.AreEqual(1, employee.Length);
        }

        /// <summary>
        /// Test Case for Modifying Comment/Remark for the Employee which is not Present in the List
        /// </summary>

        [TestMethod]
        [ExpectedException(typeof(FaultException<EmployeeManagementFixture.EmployeeServiceReference.EmployeeServiceFault>))]
        public void ModifyCommentWhenEmployeeNotExits()
        {

            var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate");
            var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve");

            var emp = createClient.CreateEmployee(1, "saifuddin", "Hello..Again..");
            createClient.AddEmployee(emp);

            var empModified = createClient.ModifyComment(6, "Modified Hello...");
        }

        /// <summary>
        /// Test Case for Retrieving Details of Employee which is not Present in the List
        /// </summary>

        [TestMethod]
        [ExpectedException(typeof(FaultException<EmployeeManagementFixture.EmployeeServiceReference.EmployeeServiceFault>))]
        public void GetEmployeeWhenNoEmployeeExits()
        {

            var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate");
            var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve");

            EmployeeManagement[] employee = retrieveClient.GetAllEmployee();
            Assert.AreEqual(0, employee.Length);
            
        }

        /// <summary>
        /// Test Case for Removing Details of Employee when Employee is Not Present in List
        /// </summary>

        [TestMethod]
        [ExpectedException(typeof(FaultException<EmployeeManagementFixture.EmployeeServiceReference.EmployeeServiceFault>))]
        public void RemoveEmployeeWhenEmployeeNotExists()
        {

            var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate");
            var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve");

            createClient.RemoveEmployee(1);

        }

        /// <summary>
        /// Test Case For Creating Employee , when Its Already Present in the List
        /// </summary>

        [TestMethod]
        [ExpectedException(typeof(FaultException<EmployeeManagementFixture.EmployeeServiceReference.EmployeeServiceFault>))]
        public void CreateEmployeeWhenItsAlreadyExists()
        {

            var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate");
            var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve");

            var emp = createClient.CreateEmployee(1, "saifuddin", "Hello..Again..");
            createClient.AddEmployee(emp);

            var empOne = createClient.CreateEmployee(1, "saifuddin", "Hello..Again..");
            createClient.AddEmployee(empOne);
            
        }

    }
}
