using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagementFixture.EmployeeServiceReference;
using EmployeeManagementSystem;

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

            var empOneDetails = retrieveClient.SearchById(1);

            Assert.AreEqual(1, empOneDetails.EmpID);
            Assert.AreEqual("saif", empOneDetails.EmpName);
            Assert.AreEqual("Hello..", empOneDetails.Comment);

            var empTwoDetails = retrieveClient.SearchById(2);

            Assert.AreEqual(2, empTwoDetails.EmpID);
            Assert.AreEqual("saifuddin", empTwoDetails.EmpName);
            Assert.AreEqual("Hello..Again..", empTwoDetails.Comment);
        }



        [TestMethod]
        public void AddCommentForExistingEmployee()
        {
            var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate");
            var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve");
            var emp=createClient.ModifyRemark(1, "Modified Hello...");

            Assert.AreEqual(1, emp.EmpID);
            Assert.AreEqual("saif", emp.EmpName);
            Assert.AreEqual("Modified Hello...", emp.Comment);
           
        }

        [TestMethod]
        public void GetAllEmployeeWithRemark()
        {
            var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate");
            var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve");
            var empThree = createClient.CreateEmployee(3, "saifBatliwala", null);
            createClient.AddEmployee(empThree);
            var empFour = createClient.CreateEmployee(4, "Batliwala", null);
            createClient.AddEmployee(empFour);

            EmployeeManagement[] employee = retrieveClient.GetAllEmployeeWithRemark();

            Assert.AreEqual(2, employee.Length);
        }

        [TestMethod]
        public void GetAllEmployee()
        {  
            var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve");
            EmployeeManagement[] employee = retrieveClient.GetAllEmployee();
            Assert.AreEqual(4, employee.Length);
        }


    }
}



/*
 * 
 *    [TestMethod]
        public void NoMethodSpecified()
        {
            string str = " /index.html HTTP/1.1\r\n";
            byte[] data = Encoding.UTF8.GetBytes(str);
            var mockRequest = new Mock<HttpRequest>(data);
            Assert.AreEqual("", mockRequest.Object.Method);
        }
*/