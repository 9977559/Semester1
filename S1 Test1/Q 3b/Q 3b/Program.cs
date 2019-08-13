using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_3b
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking for the user to input a guess at the answer of x
            Console.WriteLine("Can you solve this algebra Question?");
            Console.WriteLine("2(x-3) + x = 12");
//Destination of the goto 
            tryAgain:
            Console.WriteLine("What is the value of x?:");
            //the users guess saved as int
            int guess = Convert.ToInt32(Console.ReadLine());
            //the correct answer as an int
            int x = 6;
            //if statement if guess is correct
            if (guess == x)
            {
                Console.WriteLine("Correct!");
                Console.WriteLine("Press Enter to exit..");
                Console.ReadLine();
                
                
            }
            //if guess is not correct
            else if (guess != x)
                    {



                Console.WriteLine("Incorrect.. try agin");
                //loops back to tryAgain:
                goto tryAgain;
            }


           /*
            * Working for x
            2(x-3)+x=12
            2x-6+x=12
            (2x+x) = 3x -6 = 12
            3x = 18
            3x/3=x  18/3=6
            x=6
                    
             */
        }
    }
}
