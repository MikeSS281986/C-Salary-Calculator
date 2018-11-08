using System;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.Write("Calculate yearly salary or hourly wage: y/h? ");
            string myAnswer = Console.ReadLine();
            if (myAnswer == "y")
            {
                YearlyWage();
                Reset();
                return false;
            }
            else if (myAnswer == "h")
            {
                HourlyWage();
                Reset();
                return false;
            }
            else
            {
                Console.WriteLine("Please Enter a valid response...");
                Console.ReadLine();
                return true;
            }
        }

        private static void HourlyWage()
        {
            Console.Write("How much do you make an year?" +
                " Please enter amount w/o $ symbol: ");
            int yearlyVal = Int32.Parse(Console.ReadLine());
            Console.Write("How many hours do you work a week? ");
            int hourVal = Int32.Parse(Console.ReadLine());
            int hourlyAmount = (yearlyVal / 52) / hourVal;
            Console.WriteLine("You make {0:C} a hour.", hourlyAmount);
            Console.ReadLine();
        }
        private static void YearlyWage()
        {
            Console.Write("How much do you make an hour?" +
                " Please enter amount w/o $ symbol: ");
            double moneyVal = double.Parse(Console.ReadLine());
            Console.Write("How many hours do you work a week? ");
            int hourVal = Int32.Parse(Console.ReadLine());
            double yearlyAmount = (moneyVal * hourVal) * 52;
            Console.WriteLine("You make {0:C} a year.", yearlyAmount);
            Console.ReadLine();
        }
        private static void Reset()
        {
            Console.Write("Do you want to make another calculation? y/n ");
            string myResponse = Console.ReadLine();
            if (myResponse == "y")
            {
                Console.Clear();
                MainMenu();
            }   
        }
    }
}
