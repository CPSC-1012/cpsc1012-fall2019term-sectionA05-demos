using System;

namespace TrianglePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseSize;
            char symbol;
            string userInput;

            Console.Write("Enter the base size of triangle: ");
            userInput = Console.ReadLine();
            baseSize = int.Parse(userInput);
            Console.Write("Enter the symbol to print for triangle: ");
            userInput = Console.ReadLine();
            symbol = char.Parse(userInput);
            // Solution using for loop
            for (int rowCount = 0; rowCount < baseSize; rowCount += 1)
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
