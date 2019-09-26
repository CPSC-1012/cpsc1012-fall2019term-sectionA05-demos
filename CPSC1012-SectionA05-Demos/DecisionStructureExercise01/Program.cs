using System;

namespace DecisionStructureExercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a random number between 0 and 1
            // 0 for head, 1 for tail

            // Create an object capable of generating random numbers
            Random rand = new Random();
            // Generate a random number between 0 and 1
            int randomNumber = rand.Next(0, 2);
            Console.WriteLine(randomNumber);

            // Prompt for and read in a guess value
            // 0 for head, 1 for tail
            Console.WriteLine("Enter 0 for head, 1 for tail: ");
            String userInput;
            userInput = Console.ReadLine();
            int guessNumber = int.Parse(userInput);

            // Determine and report if the user guess
            // matches the random number
            if (guessNumber == randomNumber)
            {
                Console.WriteLine("Your guess is correct");
            }
            else
            {
                Console.WriteLine("Your guess is incorrect");
            }
            //string result = (guessNumber == randomNumber) ? "correct" : "incorrect";
            //Console.WriteLine($"Your guess is {result}");
        }
    }
}
