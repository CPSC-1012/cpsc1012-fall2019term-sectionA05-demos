using System;

namespace DecisionStructureExercise03
{
    class Program
    {
        // A scissor-rock-paper game.
        static void Main(string[] args)
        {
            const int Scissor = 0;
            const int Rock = 1;
            const int Paper = 2;

            // Generate a random number between 0 and 2.
            Random rand = new Random();
            int computerNumber = rand.Next(0, 2 + 1);

            // Prompt and read in the user choice
            Console.WriteLine("Scissor (0), rock (1), paper(2):");
            string userInput;
            userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);

            // Determine whether the user wins, loses, or draws in the game.
            /*  The rules of the game is as follows:
             *      scissor (0) cuts a paper (2)
             *      rock (1) can knock a scissor (0)
             *      paper (2) can wrap a rock (1)
             * */
            switch (userNumber)
            {
                case 0: // user chooses scissor
                    // user wins if computer choose paper (2)
                    if (computerNumber == Paper)
                    {
                        Console.WriteLine("The computer is paper. You are scissor. You win.");
                    }
                    // user loses if computer choose rock (1)
                    else if (computerNumber == Rock)
                    {
                        Console.WriteLine("The computer is rock. You are scissor. You lose.");
                    }
                    // user ties if computer choose scissor (0)
                    else
                    {
                        Console.WriteLine("Both are paper. Its a draw");
                    }
                    break;
                case 1: // user chooses rock
                    break;
                case 2: // user chooses paper
                    break;
                default: // invalid user choice
                    Console.WriteLine("Invalid input choice.");
                    break;
            }

            
        }
    }
}
