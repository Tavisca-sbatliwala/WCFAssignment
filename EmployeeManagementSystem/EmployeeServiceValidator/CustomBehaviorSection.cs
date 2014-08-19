using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Web;
using EmployeeServiceValidator;

namespace EmployeeServiceValidator
{
    public class CustomBehaviorSection : BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get
            {
                return typeof(ValidationBehavior);
            }
        }

        protected override object CreateBehavior()
        {
            return new ValidationBehavior();

        }
    }
}
