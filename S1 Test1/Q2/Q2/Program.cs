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

            Console.WriteLine("This program will give the Total sum of 5 prices");
            
            double total = 0;
            //for loop to loop 5 times
            for (int i = 1; i <= 5; i++)
            {
                //asks user to enter a pice for each item up to item 5
                Console.WriteLine($"Enter the Price of Item {i}:");
                //adds the user imputs together 
                total = total + double.Parse(Console.ReadLine());
            }
            //prints the answer to the console with a message
            Console.WriteLine($"The total of  those items is: ${total}");
            Console.ReadLine();



        }
    }
}
