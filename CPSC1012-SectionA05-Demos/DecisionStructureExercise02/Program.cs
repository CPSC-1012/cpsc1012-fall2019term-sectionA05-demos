using System;

namespace DecisionStructureExercise02
{
    class Program
    {
        // A program to determine if a input year is a leap year.
        static void Main(string[] args)
        {
            // Prompt and read in the input year
            Console.WriteLine("Enter a year: ");
            string userInput;
            userInput = Console.ReadLine();
            int year = int.Parse(userInput);

            // Determine if input year is a leap year.
            // A leap year is when there are 29 days instead of 28 in a February
            // A leap year is divisible by 4 but not by 100, OR if it is divisble by 400
            bool isLeapYear =
                year % 4 == 0           // divisble by 4
                &&
                !(year % 100 == 0)     // not divisble by 100
                ||
                year % 400 == 0;       // divisible by 400     
            if (isLeapYear)
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }

        }
    }
}
