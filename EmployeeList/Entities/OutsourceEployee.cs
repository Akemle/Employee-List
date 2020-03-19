using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeList.Entities
{
    class OutsourceEployee : Employee
    {
        public double AdditionalCharge;


        public override double Payment()
        {
            
            return base.Payment() + (AdditionalCharge + (AdditionalCharge*0.1)); 

        }


    }
}
