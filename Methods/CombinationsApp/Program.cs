using System;

namespace CombinationsApp
{
    // This program calculates the number of combinations of n items
    // taken r at a time using formula:
    //  combinations = n * (n-1)/2 * (n-2)/3 * .... * (n-r +1 )/r
    //               = n! / r! / (n-r)!
    // n=5, r=2, combinations = 10
    // n=52, r=6, combinatios = 25827165

    class Program
    {
        static long Combinations(int n, int r)
        {
            long result = 1;
            result = Factorial(n) / Factorial(r) / Factorial(n - r);
            return result;
        }
        static long Factorial(int num)
        {
            long result = 1;
            for (int count = num; count > 1; count -= 1)
            {
                result = result * count;
            }

            return result;
        }
        static void Main(string[] args)
        {
            int ballCount;
            int ballsSelected;
            string userInput;
            Console.WriteLine("Enter the number of balls in the bin:");
            userInput = Console.ReadLine();
            ballCount = int.Parse(userInput);
            Console.WriteLine("Enter the number of balls selected from the bin:");
            userInput = Console.ReadLine();
            ballsSelected = int.Parse(userInput);
            long result = Combinations(ballCount, ballsSelected);
            Console.WriteLine($"Odds of winning: 1 in {result}");
        }
    }
}
