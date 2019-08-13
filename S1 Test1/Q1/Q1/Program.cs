using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This program will give the result of base^exponent...");
            Console.WriteLine("Enter the value of the base:");
            //asks user to enter the base value and saves as a double
            double ba = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of the exponent:");
            //Asks user to enter the exponent and saves as an int
            int ex = Convert.ToInt32(Console.ReadLine());
            // declaring new variable for loop
            double ans = ba;
             
           
             
           
            
            //for loop to work out ba^ex
            for (int i = 1; i <= ex; i++)
            {
               
                ans = ans * ba;
            }
            ans = ans / ba;

            //prints out the answer to the console
            Console.WriteLine($"{ba}^{ex}={ans}");
            Console.ReadLine();
             
             
             
             
             
            

    
        }
    }
}
