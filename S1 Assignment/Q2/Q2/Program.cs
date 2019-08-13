using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {

            //ASKS FOR USER INPUT, SAVES AS VARIABLES 
            Console.WriteLine("Enter Employee Name:\n");
            string _name = Console.ReadLine();

            Console.WriteLine($"What is {_name}'s Tax rate?");
            double _tax = double.Parse(Console.ReadLine());
            Console.WriteLine($"What is {_name}'s Gross Income");
            double _gross = double.Parse(Console.ReadLine());

            //CREATES NEW INSTANCE OF THE EMPLOYEE OBJECT, USES CONSTRUCTOR AND THE INPUT VARIABLES
            Employee E1 = new Employee();
            E1.Name = _name;
            E1.Gross = _gross;
            E1.Tax = _tax;

            //DISPLAYS THE INFOMATION OF THE OBJECT EMPLOYEE, GROSS AND NET ARE DISPLAYED 
            //IN CURRENCY FORMAT
            Console.Write($"{E1.Name}\n" +
                $"Tax Rate: {E1.Tax}%\n" +
                $"Gross Income: ");
            Console.WriteLine("{0:C}", +E1.Gross);
            Console.WriteLine("Annual Salary: " + "{0:C}", E1.NetSalary());
            Console.Read();
        }

        //EMPLOYEE CLASS
        class Employee
        {
            //CLASS PROPERTIES
            public string Name { get; set; }
            public double Gross { get; set; }
            public double Tax { get; set; }

            public Employee()
            {
                Console.WriteLine("New Employee Record Created...");
            }

            //EMPLOYEE CLASS METHOD TO CALCULATE NET FROM GROSS
            public double NetSalary()
            {
                return Gross * (1 - Tax / 100);
            }


        }
    }
}
