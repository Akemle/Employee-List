using System;
using System.Collections.Generic;
using EmployeeList.Entities;
namespace EmployeeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Digite o número total de funcionarios: ");
            int numEmp = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numEmp; i++)
            {
                Console.WriteLine("Employee number " + i + " data:");
                Console.WriteLine("Outsourced? (y/n)");
                char outsourced = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                //passando pra lista de OutsourceEmployee ou Employee 

                if(outsourced == 'y')
                {
                    Console.WriteLine("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourceEployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }


            Console.WriteLine("Payments: ");
            foreach(Employee emp in list)
            {
                Console.WriteLine($"{emp.Name} - {emp.Payment()}");
            }
            


        }
    }
}
