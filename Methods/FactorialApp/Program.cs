using System;

namespace FactorialApp
{
    class Program
    {
        // Define a method named Factorial that takes in a number
        // and returns the factorial of that number
        static long Factorial(int num)
        {
            long result = 1;
            for(int count = num; count > 1; count -= 1)
            {
                result = result * count;
            }

            return result;
        }
        static void Main(string[] args)
        {
            int num;
            string userInput;
            long result;
            // Prompt and read in a number
            Console.Write("Enter a number:");
            userInput = Console.ReadLine();
            num = int.Parse(userInput);
            // Display the factorial of the input number
            result = Factorial(num);
            Console.WriteLine($"{num}! is {result}");
        }
    }
}
