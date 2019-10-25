using System;

namespace Cubed
{
    class Program
    {
        static void Main(string[] args)
        {

// Generate a random number between 1 and 100
Random rand = new Random();
int randNumber = rand.Next(1, 100 + 1);
Console.WriteLine(randNumber);
// Track number of attempts
int attempts = 0;

// Prompt and read in the guess number
string userInput;
int userNumber;
bool gameOver = false;

while (!gameOver)
{
    Console.WriteLine("Enter your guess: ");
    userInput = Console.ReadLine();
    userNumber = int.Parse(userInput);

    attempts += 1;

    // Determine if guess is too high, too low, or correct
    if (userNumber > randNumber)
    {
        Console.WriteLine("Your guess is too high");
    }
    else if (userNumber < randNumber)
    {
        Console.WriteLine("Your guess is too low");
    }
    else
    {
        Console.WriteLine($"Yes, the number is {userNumber}");
        Console.WriteLine($"It took you {attempts} attempts to get correct answer");
        gameOver = true;
    }

}
        }
    }
}
