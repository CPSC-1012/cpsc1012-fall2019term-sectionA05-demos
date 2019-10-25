using System;

namespace RectanglePattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows;
            int columns;
            char symbol;
            string userInput;

            Console.Write("Enter the number of rows for rectangle: ");
            userInput = Console.ReadLine();
            rows = int.Parse(userInput);
            Console.Write("Enter the number of columns per row: ");
            userInput = Console.ReadLine();
            columns = int.Parse(userInput);
            Console.Write("Enter the symbol to print for rectangle: ");
            userInput = Console.ReadLine();
            symbol = char.Parse(userInput);
            // Solution using for loop
            for (int rowCount = 0; rowCount < rows; rowCount += 1)
            {
                for(int columnCount = 0; columnCount < columns; columnCount += 1 )
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
