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
            //Declearing variables
            string user;
            string pass;
            string passVer;
            //greets user
            Console.WriteLine("Welcome to the logon system \n" +
                "Please set your username and password... \n");
            //start location
        start:
               
            //asks for username
            Console.WriteLine("Please enter your username:");

            user = Console.ReadLine();
            //sends username to method
            string userlen = ValidateUsername(user);

            //diffrent outcomes depending on what methos returned 
            if (userlen == "0")
            {
                Console.WriteLine($"Thank you {user}\n");
            }
            else
            {
                Console.WriteLine("Please enter a username 8 characters minimum");
                goto start;
            }

             
            
                    //start2 location
                 start2:
                    //asks to enter password
                    Console.WriteLine("Please enter your password: \n");
                    pass = Console.ReadLine();
          
                    //second time to match
                    Console.WriteLine("Please verify your password: \n");
                    passVer = Console.ReadLine();

                    //sends passwords to method
                    string passcheck = ValidatePassword(pass, passVer);

                    //different outcomes based off method return
                    if (passcheck == "1")
                    {
                        Console.WriteLine("Password Not Accepted.. Minimum 8 characters needed \n" +
                            "Make sure they match.");
                        goto start2;
                    }
                    else
                    {
                        Console.WriteLine("Password Set: ");
                    }

                    Console.WriteLine("Logon Successful");
                    Console.ReadLine();
        }
       
        
        //username method
        public static string ValidateUsername(string User)
        {
            //len is == username length of chars
            int len = User.Length;
            if (len >= 8)
            {
                return "0";
            }
            else
            { 
                return "1"; 
            }

        }
                    //password method
                    public static string ValidatePassword(string pass1, string pass2)
                    {
                        //len == first password lengh of chars 
                        int len = pass1.Length;
                        string checkLen;
                        if (len >= 8)
                        {
                            checkLen = "0";
                        }
                        else
                        {
                            checkLen = "1"; 
                        }

                        //checks if both passwords match and are long enough 
                        if (pass1 == pass2 && checkLen == "0")
                        {
                            return "0";
                        }
                        else { return "1"; }


        }


    }
}
