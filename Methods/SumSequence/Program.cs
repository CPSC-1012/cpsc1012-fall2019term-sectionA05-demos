using System;

namespace SumSequence
{
    class Program
    {
        // Define a method named SumSequence that takes an integer n
        // and returns the sum of the integers from 1 to n.
        static int SumSequnce(int n)
        {
            int sum = 0;
            for (int number = 1; number <= n; number += 1)
            {
                sum = sum + number;
                //sum += number;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int num;
            string userInput;
            // Prompt and read in a number
            Console.Write("Enter the final term of the sequence:");
            userInput = Console.ReadLine();
            num = int.Parse(userInput);
            // Call the SumSequnce method and 
            // display the sum of a sequence of integers
            int sum = SumSequnce(num);
            Console.WriteLine($"The sum of the integers from 1 to {num} is {sum}");

        }
    }
}
