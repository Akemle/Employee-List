using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeList.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        //constructors
        public Employee() { 
        
        }

        public Employee(string name, int hours, double valuerPerHour)
        {
            Name = name;        
            Hours = hours;
            ValuePerHour = valuerPerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }


    }
}
    