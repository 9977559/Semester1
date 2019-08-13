using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program  to add 2 matricies together: \n");
            Random rand = new Random();

            //Declaring 3 diffrent 2d arrays 
            int[,] testarray = new int[3, 3];
            int[,] testarray2 = new int[3, 3];
            int[,] testarray3 = new int[3, 3];

            //for loop to fill array A with random nums between 1 and 10
            for (int i = 0; i < testarray.GetLength(0); i++)
            {
                for (int j = 0; j < testarray.GetLength(1); j++)
                {
                    testarray[i, j] = rand.Next(-10, 11);
                }
            }
            Console.WriteLine("Array A:");
            //calling the display method
            Display(testarray);
            Console.WriteLine();


            //loop to fill Array B with rand nums between 1 and 10
            for (int k = 0; k < testarray2.GetLength(0); k++)
            {
                for (int l = 0; l < testarray2.GetLength(1); l++)
                {
                    testarray2[k, l] = rand.Next(-10, 11);
                }

            }
            Console.WriteLine("Array B:");
            Display(testarray2);
            Console.WriteLine();

            //Loop to add Arrays A and B together to make Array C
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    testarray3[i, j] = testarray[i, j] + testarray2[i, j];

                }
                Console.WriteLine("Array C: ");
                Display(testarray3);
                Console.ReadLine();
            }

            Console.ReadLine();

        }
        //Display Method that prints out array using loop and get length
        public static void Display(int[,] arr)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    Console.Write(arr[i, j] + "  ");
                }
                Console.WriteLine();
            }

        }
    }
}
