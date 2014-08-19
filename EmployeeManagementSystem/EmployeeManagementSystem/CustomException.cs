using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EmployeeManagementSystem
{
    [DataContract]
    public class EmployeeAlreadyExists
    {
        [DataMember]
        public int FaultId { get; set; }
        [DataMember]
        public string FaultMessage { get; set; }
        [DataMember]
        public string FaultDetail { get; set; }
    }

    [DataContract]
    public class EmployeeDoesNotExists
    {
        [DataMember]
        public int FaultId { get; set; }
        [DataMember]
        public string FaultMessage { get; set; }
        [DataMember]
        public string FaultDetail { get; set; }
    }

}