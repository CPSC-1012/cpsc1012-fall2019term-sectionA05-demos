using System;

namespace ExceptionHandlingDemo01
{
    class Program
    {
        static int GetIntegerValue(string message)
        {
            int integerValue = 0;
            string userInput;
            bool validInput = false;
            do
            {
                Console.Write(message);
                userInput = Console.ReadLine();
                try
                {
                    integerValue = int.Parse(userInput);
                    validInput = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid input. You must enter an integer value");
                }
            } while (!validInput);

            return integerValue;
        }
        // This program prompts and reads in an integer number.
        // If the input is an integer number display its value,
        // otherwise display an message that they need to 
        // enter an integer value
        static void Main(string[] args)
        {
            int num1 = GetIntegerValue("Enter first number:");
            int num2 = GetIntegerValue("Enter second number:");
            int sum = num1 + num2;
            Console.WriteLine($"The sum of {num1} + {num2} = {sum}");
        }
    }
}
