using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        /*
         * /////////////////////////////////EX 01///////////////////////////////////

      
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to make opposite:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"your opposite number is: {reverseSign(num1)}");
            Console.ReadLine();





        }

        static int reverseSign(int num0)
        {
            num0 = num0 * -1 ;
            return num0;
        }
        */
        /*///////////////////////////////////EX 02////////////////////////////////////
        static void Main(string[] args)
        {
            Console.WriteLine("this programs converts Miles to the correct messurement");
            Console.WriteLine("Enter a number in miles");
            int mile = int.Parse(Console.ReadLine());
            Console.WriteLine($"{mile} Miles converted to Km's is {Kms(mile)}");
            Console.ReadLine();


        }

        static double Kms(double km)
        {
            return km * 1.609;
        }
        */

       /*/////////////////////////////////EX03/////////////////////////////*/
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Radius");
            double rad = (Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine($"The Circumference of your circle is {Circumference(rad)} ");
            Console.WriteLine($"And the Area of your circle is {Area(rad)}");
            Console.ReadLine();

        }
        static double Area(double radius)
        {
            return 2 * Math.PI * radius;
        }
       static double Circumference(double radius)
        {
            return (radius * radius) * Math.PI;
        } 
    }

}
