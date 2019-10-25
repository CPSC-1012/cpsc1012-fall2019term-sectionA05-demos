using System;

namespace StairsStepPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps;
            char symbol;
            string userInput;

            Console.Write("Enter the number of steps of staircase: ");
            userInput = Console.ReadLine();
            steps = int.Parse(userInput);
            Console.Write("Enter the symbol to print for staircase: ");
            userInput = Console.ReadLine();
            symbol = char.Parse(userInput);
            // Solution using for loop
            for (int rowCount = 0; rowCount < steps; rowCount += 1)
            {
                for (int columnCount = 0; columnCount < rowCount + 1; columnCount += 1)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
