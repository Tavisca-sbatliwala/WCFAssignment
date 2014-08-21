﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagementFixture.EmployeeServiceReference;
using EmployeeManagementSystem;
using System.ServiceModel;
using System.Data;

namespace EmployeeManagementFixture
{
    /// <summary>
    /// Specifications: Test Scenarios
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
        private TestContext _testcontextinstance;

        public TestContext TestContext
        {
            get { return _testcontextinstance; }
            set { _testcontextinstance = value; }
        }
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
            using (var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate"))
            using (var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve"))
            {

                var emp = createClient.CreateEmployee(1, "saif", "Hello..");
                createClient.AddEmployee(emp);

                var empDetails = retrieveClient.GetById(1);
                Assert.AreEqual(1, empDetails.EmployeeID);
                Assert.AreEqual("saif", empDetails.EmployeeName);
                Assert.AreEqual("Hello..", empDetails.Comment);
            }
        }


        [TestMethod]
        public void AddAgainEmployeeDetails()
        {
            using (var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate"))
            using (var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve"))
            {

                var emp = createClient.CreateEmployee(2, "saifuddin", "Hello..Again..");
                createClient.AddEmployee(emp);

                var empTwo = createClient.CreateEmployee(1, "saif", "Hello..");
                createClient.AddEmployee(empTwo);

                var empOneDetails = retrieveClient.GetById(1);
                Assert.AreEqual(1, empOneDetails.EmployeeID);
                Assert.AreEqual("saif", empOneDetails.EmployeeName);
                Assert.AreEqual("Hello..", empOneDetails.Comment);

                var empTwoDetails = retrieveClient.GetById(2);
                Assert.AreEqual(2, empTwoDetails.EmployeeID);
                Assert.AreEqual("saifuddin", empTwoDetails.EmployeeName);
                Assert.AreEqual("Hello..Again..", empTwoDetails.Comment);
            }
        }

        /// <summary>
        /// Test Case for Adding Comment/Remark for Existing Employee in the List
        /// </summary>
        [TestMethod]
        public void AddCommentForExistingEmployee()
        {
            using (var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate"))
            {

                var emp = createClient.CreateEmployee(1, "saif", "Hello..");
                createClient.AddEmployee(emp);

                var empModified = createClient.ModifyComment(1, "Modified Hello...");
                Assert.AreEqual(1, empModified.EmployeeID);
                Assert.AreEqual("saif", empModified.EmployeeName);
                Assert.AreEqual("Modified Hello...", empModified.Comment);
            }
        }
        /// <summary>
        /// Test Case for Retrieving Details of Employee , if there Comment is not null
        /// </summary>

        [TestMethod]
        public void GetAllEmployeeWithComment()
        {
            using (var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate"))
            using (var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve"))
            {

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
        }

        /// <summary>
        /// Test Case for Retrieving Details of all the Employee
        /// </summary>
        [TestMethod]
        public void GetAllEmployee()
        {
            using (var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate"))
            using (var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve"))
            {

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
        }

        /// <summary>
        /// Test Case for Retrieving Details of Employee by using Employee Name
        /// </summary>
        [TestMethod]
        public void RetrieveEmployeeByName()
        {
            using (var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate"))
            using (var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve"))
            {

                var emp = createClient.CreateEmployee(2, "saifuddin", "Hello..Again..");
                createClient.AddEmployee(emp);

                var empTwo = createClient.CreateEmployee(1, "saif", "Hello..");
                createClient.AddEmployee(empTwo);

                var result = retrieveClient.GetByName("saif");
                Assert.AreEqual(1, result.EmployeeID);
                Assert.AreEqual("saif", result.EmployeeName);
                Assert.AreEqual("Hello..", result.Comment);
            }
        }
        /// <summary>
        /// Test Case for Retrieving Details of Employee by using Employee ID
        /// </summary>

        [TestMethod]
        public void RetrieveEmployeeByID()
        {
            using (var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate"))
            using (var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve"))
            {

                var emp = createClient.CreateEmployee(2, "saifuddin", "Hello..Again..");
                createClient.AddEmployee(emp);

                var empTwo = createClient.CreateEmployee(1, "saif", "Hello..");
                createClient.AddEmployee(empTwo);

                var result = retrieveClient.GetById(2);
                Assert.AreEqual(2, result.EmployeeID);
                Assert.AreEqual("saifuddin", result.EmployeeName);
                Assert.AreEqual("Hello..Again..", result.Comment);
            }
        }

        /// <summary>
        /// Test Case for Removing Details of Employee by using Employee ID
        /// </summary>

        [TestMethod]
        public void RemoveEmployeeById()
        {
            using (var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate"))
            using (var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve"))
            {

                var emp = createClient.CreateEmployee(2, "saifuddin", "Hello..Again..");
                createClient.AddEmployee(emp);

                var empTwo = createClient.CreateEmployee(1, "saif", "Hello..");
                createClient.AddEmployee(empTwo);

                createClient.RemoveEmployee(1);
                EmployeeManagement[] employee = retrieveClient.GetAllEmployee();
                Assert.AreEqual(1, employee.Length);
            }
        }

        /// <summary>
        /// Test Case for Modifying Comment/Remark for the Employee which is not Present in the List
        /// </summary>

        [TestMethod]
        public void ModifyCommentWhenEmployeeNotExits()
        {
           
            using (var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate"))
            {
                var emp = createClient.CreateEmployee(1, "saifuddin", "Hello..Again..");
                createClient.AddEmployee(emp);
                try
                {
                    var empModified = createClient.ModifyComment(6, "Modified Hello...");
                }
                catch (FaultException<EmployeeServiceFault> fault)
                {
                    Assert.AreEqual(100,fault.Detail.FaultId);
                }
            }
        }

        /// <summary>
        /// Test Case for Retrieving Details of Employee which is not Present in the List
        /// </summary>

        [TestMethod]
        public void GetEmployeeWhenNoEmployeeExits()
        {

            using (var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve"))
            {
                try
                {
                    EmployeeManagement[] employee = retrieveClient.GetAllEmployee();
                }
                catch (FaultException<EmployeeServiceFault> fault)
                {
                    Assert.AreEqual("Employee Does not exits", fault.Detail.FaultMessage);
                }
              
            }
        }

        /// <summary>
        /// Test Case for Removing Details of Employee when Employee is Not Present in List
        /// </summary>

        [TestMethod]
        public void RemoveEmployeeWhenEmployeeNotExists()
        {

            using (var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate"))
            {
                try
                {
                    createClient.RemoveEmployee(1);
                }
                catch (FaultException<EmployeeServiceFault> fault)
                {
                    Assert.AreEqual("Employee Does not exits", fault.Detail.FaultMessage);
                }
            }
        }

        /// <summary>
        /// Test Case For Creating Employee , when Its Already Present in the List
        /// </summary>

        [TestMethod]
        public void CreateEmployeeWhenItsAlreadyExists()
        {

            using (var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate"))
            {
                var emp = createClient.CreateEmployee(1, "saifuddin", "Hello..Again..");
                createClient.AddEmployee(emp);
                try
                {
                    var empOne = createClient.CreateEmployee(1, "saifuddin", "Hello..Again..");
                    createClient.AddEmployee(empOne);
                }
                catch (FaultException<EmployeeServiceFault> fault)
                {
                    Assert.AreEqual("Employee Already Exists", fault.Detail.FaultMessage);
                }
            }
        }

        [TestMethod]
        public void CreateEmployeeWithInvalidEmployeeID()
        {

            using (var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate"))
            {
                try
                {
                    var emp = createClient.CreateEmployee(-1, "saifuddin", "Hello..Again..");
                    createClient.AddEmployee(emp);
                }
                catch (FaultException<EmployeeServiceFault> fault)
                {
                    Assert.AreEqual("Employee ID Should be Postive", fault.Detail.FaultMessage);
                }
            }
        }

        [TestMethod]
        public void CreateEmployeeWithInvalidEmployeeName()
        {

            using (var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate"))
            {
                try
                {
                    var emp = createClient.CreateEmployee(1, "sai12321", "Hello..Again..");
                    createClient.AddEmployee(emp);
                }
                catch (FaultException<EmployeeServiceFault> fault)
                {
                    Assert.AreEqual("Employee Name Should Contains Only Letters", fault.Detail.FaultMessage);
                }
            }
        }

        [TestMethod]
        [DeploymentItem(@"D:\WCFAssignment\EmployeeManagementSystem\EmployeeManagementFixture\EmployeeXMLData.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                           @"D:\WCFAssignment\EmployeeManagementSystem\EmployeeManagementFixture\EmployeeXMLData.xml",
                           "AddEmployee",
                            DataAccessMethod.Sequential)]
        public void CreateEmployeeUsingDataSource()
        {
            using (var createClient = new EmployeeCreateClient("BasicHttpBinding_IEmployeeCreate"))
            using (var retrieveClient = new EmployeeRetrieveClient("WSHttpBinding_IEmployeeRetrieve"))
            {
                int empId = Int32.Parse((string)_testcontextinstance.DataRow["EmployeeId"]);
                string empName = _testcontextinstance.DataRow["EmployeeName"].ToString();
                string empComment = _testcontextinstance.DataRow["EmployeeComment"].ToString();
                var emp = createClient.CreateEmployee(empId, empName, empComment);
                createClient.AddEmployee(emp);

                var empOneDetails = retrieveClient.GetById(empId);

                Assert.AreEqual(1, empOneDetails.EmployeeID);
                Assert.AreEqual("saif", empOneDetails.EmployeeName);
                Assert.AreEqual("Hello", empOneDetails.Comment);
            }
        }

    }
}
