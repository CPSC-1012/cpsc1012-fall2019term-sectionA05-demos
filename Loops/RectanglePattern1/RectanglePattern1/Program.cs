using System;

namespace RectanglePattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows;
            string userInput;
            Console.Write("Enter the number of rows for rectangle: ");
            userInput = Console.ReadLine();
            rows = int.Parse(userInput);
            // Solution using for loop
            for (int rowCount = 0; rowCount < rows; rowCount += 1)
            {
                Console.WriteLine("**********");
            }
            // Solution using while loop
            //int rowCount = 0;
            //while (rowCount < rows)
            //{
            //    Console.WriteLine("**********");
            //    rowCount += 1;
            //}
        }
    }
}
