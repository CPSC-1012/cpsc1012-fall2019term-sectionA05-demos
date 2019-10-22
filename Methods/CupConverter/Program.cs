using System;

namespace CupConverter
{
    // This program converts cups to fluid ounces.
    class Program
    {
        static void Main(string[] args)
        {
            double cups;
            double ounces;
            // Get the number of cups from the user
            cups = GetCups();
            // Convert the number of cups to fluid ounces
            ounces = CupsToOunces(cups);
            // Display the results
            DisplayResults(cups, ounces);
        }
        // Define a method named GetCups that prompts the user to enter the 
        // number of cups and then return the value as a double
        static double GetCups()
        {
            double numCups;
            String userInput;
            Console.Write("Enter the number of cups: ");
            userInput = Console.ReadLine();
            numCups = double.Parse(userInput);
            return numCups;
        }
        // Define a method named CupsToOunces that accept the number of cups 
        // as a parameter and then return the equivalent number of fluid ounces
        // as a double using the formula: 1 cup = 8 ounces
        static double CupsToOunces(double cups)
        {
            double ounces;
            ounces = cups * 8;
            return ounces;
        }

        // Define a method named DisplayResults that display a message indicating
        // the result of the conversion
        static void DisplayResults(double cups, double ounces)
        {
            Console.WriteLine($"{cups} cups equals to {ounces} fluid ounces.");
        }
    }
}
