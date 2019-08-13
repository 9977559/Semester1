using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Q1

            string[] names = new string[3];
            Console.WriteLine("Please Enter the name of the GOLD Medal winner: ");
            names[0] = Console.ReadLine();
            Console.WriteLine("Please Enter the name of the SILVER Medal winner: ");
            names[1] = Console.ReadLine();
            Console.WriteLine("Please Enter the name of the BRONZE Medal winner: ");
            names[2] = Console.ReadLine();

            Console.WriteLine("Which Winner would you like to see? \n" +
                "1. Gold\n" +
                "2. Silver\n" +
                "3. Bronze\n" +
                ": ");

            int input = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Winner is: {names[input -1]}");
            Console.ReadKey();
            */

            /*Q2

            string[] names = new string[5];
            Console.WriteLine("Please Enter name 1: ");
            names[0] = Console.ReadLine();
            Console.WriteLine("Please Enter name 2: ");
            names[1] = Console.ReadLine();
            Console.WriteLine("Please Enter name 3: ");
            names[2] = Console.ReadLine();
            Console.WriteLine("Please Enter name 4: ");
            names[3] = Console.ReadLine();
            Console.WriteLine("Please Enter name 5: ");
            names[4] = Console.ReadLine();

            Console.WriteLine($"The first name in the array: {names[0]}");
            Console.WriteLine($"The last name in the array: {names[4]}");

            Console.ReadLine();
            */

            /*Q3

            Console.WriteLine("This is a translater app\n" +
                "can translate these words:\n" +
                "1.Hello\n" +
                "2.Welcome\n" +
                "3.Love\n" +
                "4.Meetig\n" +
                "5.Gift\n" +
                "\n" +
                "Which word would you like translated into Dutch?: ");
         
            int num1 = int.Parse(Console.ReadLine());
            string[] dutch = new string[5];
            dutch[0] = "Hallo";
            dutch[1] = "Welkom";
            dutch[2] = "liefde";
            dutch[3] = "Vergadering";
            dutch[4] = "Gift";

            string[] english = new string[5];
            english[0] = "Hello";
            english[1] = "Welcome";
            english[2] = "Love";
            english[3] = "Meeting";
            english[4] = "Gift";

            Console.WriteLine($"English = {english[num1-1]} \nDutch = {dutch[num1-1]}");

            Console.ReadLine(); 
         
                */
                /*Q3 a different way*/
            string[] english = { "Hello", "Welcome", "Love" };
            string[] dutch = { "Hallo", "Welkom", "Liefde" };
            Console.WriteLine("What would you like translated?");
            int i = 1;
            foreach (string x in english)
            {
                Console.WriteLine($"{i}: {x} ...");
                i++;
            }
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine($"{english[input -1]} is {dutch[input-1]} in dutch.");
            Console.ReadLine();



        }
    }
}
