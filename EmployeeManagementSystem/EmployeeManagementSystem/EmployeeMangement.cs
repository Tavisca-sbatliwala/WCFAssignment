using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    [DataContract]
    public class EmployeeManagement
    {
        [DataMember]
        public int EmpID { get; set; }
        [DataMember]
        public string EmpName { get; set; }
        [DataMember]
        public string Comment { get; set; }
        [DataMember]
        public DateTime TimeSubmitted { get; set; }

    }
}