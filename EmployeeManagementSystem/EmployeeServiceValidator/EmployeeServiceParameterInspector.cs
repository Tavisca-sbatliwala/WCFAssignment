
using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text.RegularExpressions;

namespace EmployeeServiceValidator
{
    public class EmployeeServiceParameterInspector : IParameterInspector
    {
        public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
        {

        }

        public object BeforeCall(string operationName, object[] inputs)
        {

            if (operationName.Equals("CreateEmployee"))
            {

                int empId = (int)inputs[0];
                string empName = inputs[1] as string;
                string comment = inputs[2] as string;

                EmployeeIDValidator(empId);
                EmployeeNameValidator(empName);

                return null;
            }

            if (operationName.Equals("RemoveEmployee"))
            {
                int empId = (int)inputs[0];
                EmployeeIDValidator(empId);
                return null;

            }

            if (operationName.Equals("ModifyComment"))
            {
                int empId = (int)inputs[0];
                EmployeeIDValidator(empId);
                return null;
            }

            if (operationName.Equals("SearchById"))
            {
                int empId = (int)inputs[0];
                EmployeeIDValidator(empId);
                return null;
            }

            if (operationName.Equals("SearchByName"))
            {
                string empName = inputs[1] as string;
                EmployeeNameValidator(empName);
                return null;

            }

            return null;

        }

        private void EmployeeIDValidator(int empId)
        {
            Regex employeeIdRegex = new Regex("^[0-9]+$");
            if (empId < 0)
            {
                EmployeeServiceFault fault = new EmployeeServiceFault();
                fault.FaultId = 105;
                fault.FaultMessage = "Employee ID Should be Postive";
                fault.FaultDetail = "Employee ID Should be Postive ie ID Should be Greater than Zero ";
                throw new FaultException<EmployeeServiceFault>(fault, fault.FaultDetail);
            }

            if (!employeeIdRegex.IsMatch(empId.ToString()))
            {
                EmployeeServiceFault fault = new EmployeeServiceFault();
                fault.FaultId = 106;
                fault.FaultMessage = "Employee ID Should Contains only Digits";
                fault.FaultDetail = "Employee ID Should Contains only Digits i.e [0-9]";
                throw new FaultException<EmployeeServiceFault>(fault, fault.FaultDetail);
            }
        }

        private void EmployeeNameValidator(string empName)
        {
            Regex employeeNameRegex = new Regex("^[a-zA-Z]+$");
            if (empName.Equals(null))
            {
                EmployeeServiceFault fault = new EmployeeServiceFault();
                fault.FaultId = 107;
                fault.FaultMessage = "Employee Name Cannot be Null";
                fault.FaultDetail = "Employee Name Cannot be Null , It should Contain Some Valid Name  ";
                throw new FaultException<EmployeeServiceFault>(fault, fault.FaultDetail);
            }

            if (!employeeNameRegex.IsMatch(empName))
            {
                EmployeeServiceFault fault = new EmployeeServiceFault();
                fault.FaultId = 108;
                fault.FaultMessage = "Employee Name Should Contains Only Letters";
                fault.FaultDetail = "Employee Name Should Contains Only Letters i.e [Aa-Zz]";
                throw new FaultException<EmployeeServiceFault>(fault, fault.FaultDetail);
            }
        }
    }
}
