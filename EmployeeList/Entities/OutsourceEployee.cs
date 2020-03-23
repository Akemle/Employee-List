using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeList.Entities
{
    class OutsourceEployee : Employee
    {
        public double AdditionalCharge{get; set;}

        //constructors
        public OutsourceEployee()
        {

        }
        public OutsourceEployee(string name, int hours, double valuerPerHour, double additionalCharge) : base(name, hours, valuerPerHour)
        {
            AdditionalCharge = additionalCharge;
        }


        public override double Payment()
        {
            
            return base.Payment() + (AdditionalCharge + (AdditionalCharge*0.1)); 

        }


    }
}
