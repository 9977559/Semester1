using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielHollander_99775589_Test2
{
    class Program
    {//PROGRAM TO CALCULATE SALARY AND WAGES
        //DANIEL HOLLANDER
        static void Main(string[] args)
        {
        //START POINT
        start:
            //MENU SYSTEM TO CHOOSE BETWEEN SALARY AND WAGES
            Console.WriteLine("Welcome to the payroll System\n" +
                "Enter 1: to Display Salary\n" +
                "Enter 2: to Display Wages\n" +
                "Enter 1 or 2: \n");
            int one = int.Parse(Console.ReadLine());
            if (one == 1)
            {
                //SALARY 
                Console.WriteLine("Your salary is set at $80000 per year");
                //SET AT 80000
                Salary E1 = new Salary(80000, 0);
                //TWO BLANK LINES
                Console.WriteLine("Your salary per week is: $" + E1.DisplaySalary() + "\n\n");
                Console.ReadLine();
            }
            else if (one == 2)
            {
                //WAGES
                Wages E2 = new Wages(0);
                Console.WriteLine("I Will Calculate your wages...");
                Console.WriteLine("Enter the number of hours worked: ");
                int hours = int.Parse(Console.ReadLine());
                //INT TAKES THE USER IMPUT FOR NUMBER OF HOURS WORKED 
                E2.NumHours = hours;
                //USER IMPUT = NUMHOURS
                Console.WriteLine("Your wages per week are: $" + E2.DisplayWages());
                Console.ReadLine();
            }
            else
            {
                //IF USER DOESNT ENTER 1 OR 2 GOES TO START OF APP
                Console.WriteLine("Option not recognised... Try Again");
                goto start;
            }

        }
    }





}
//WAGES CLASS
class Wages
{
    //WAGES PROPERTIES
    private double HourlyRate { get; set; }
    private int numHours { get; set; }
    private double WeeklyWages { get; set; }
    public int NumHours { get; set; }
    //WAGES CONSTRUTOR
    public Wages(int numHours)
    {
        NumHours = numHours;
    }
    //METHOD TO DIPLAY WAGES
    public double DisplayWages()
    {
        HourlyRate = 33.72;

        WeeklyWages = NumHours * HourlyRate;

        //RETURNS WAGES ROUNDED TO 2 DP
        return Math.Round(WeeklyWages, 2);
    }


}
//SALARY CLASS
class Salary
{
    //SALARY PROPERTIES
    private double AnnualSalary { get; set; }
    private double WeeklySalary { get; set; }

    //SALARY CONSTRUTOR
    public Salary(double annualSalary, double weeklySalary)
    {
        AnnualSalary = annualSalary;
        WeeklySalary = weeklySalary;
        weeklySalary = AnnualSalary / 52;
    }
    //METHOD TO DISPLAY WEEKLY SALARY ROUNDED TO TWO DP
    public double DisplaySalary()
    {
        WeeklySalary = AnnualSalary / 52;
        return Math.Round(WeeklySalary, 2);
    }

}
