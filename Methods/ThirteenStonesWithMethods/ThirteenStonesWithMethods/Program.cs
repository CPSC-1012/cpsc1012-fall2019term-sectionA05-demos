/*
 * Purpose:     To simulate the game Thirteen Stones
 * 
 * Input:       Number of stones (1,2,3) chosen by player
 * 
 * Process:     Loop until the stones remaining is zero.
 *                  Ask player to pick stones
 *                  Decrement stones remaining
 *                  Swap Players
 *             
 *              Determine which player won the game
 *             
 *              Game is over when stones remaining is zero (stonesRemaining = 0)
 *              Last player to pick stones is the winner
 * 
 * Output:      Stones remaining after each pick
 *              Message indicating who won the game
 * 
 * */
using System;

namespace ThirteenStonesWithMethods
{
    class Program
    {
        static int GetIntegerValue(string message)
        {
            int integerValue = 0;
            string userInput;
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine(message);
                userInput = Console.ReadLine();
                try
                {
                    integerValue = int.Parse(userInput);
                    validInput = true;
                }
                catch
                {
                    Console.WriteLine("Invalid input value. You must enter an integer value");
                }
            }
            return integerValue;
        }
        static int GetPlayerPick(int player, int stonesLeft)
        {
            int stonesPicked = 0;
            bool validPick = false;

            while (!validPick)
            {
                stonesPicked = GetIntegerValue(
                    $"Player {player} enter the number of stones to pick (1,2,3): ");
                // Validate that stonesPicked is between 1 and 3 and less or equals stones left
                if (stonesPicked >= 1 && stonesPicked <= 3 && stonesPicked <= stonesLeft)
                {
                    validPick = true;
                }
                else
                {
                    if (stonesPicked > stonesLeft )
                    {
                        Console.WriteLine($"Invalid input value. Enter 1 to {stonesLeft}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input value. Enter 1, 2, or 3");
                    }
                }
            }

            return stonesPicked;
        }

        static void Main(string[] args)
        {
            int stonesRemaining = 13;
            int playerTurn = 1; // 1 - Player 1
                                // 2 - Player 2
            bool gameOver = false;
            int stonesPicked = 0;

            while(!gameOver)
            {
                // Prompt and read the players pick of stones
                stonesPicked = GetPlayerPick(playerTurn, stonesRemaining);

                // Decrement stones remaining 
                stonesRemaining -= stonesPicked;
                Console.WriteLine($"Stones remaining: {stonesRemaining}");

                // Determine if game is over
                if (stonesRemaining <= 0)
                {
                    gameOver = true;
                }
                else
                {
                    // Swap players
                    if (playerTurn == 1)
                    {
                        playerTurn = 2;
                    }
                    else
                    {
                        playerTurn = 1;
                    }
                }                

               
            }
            // Determine which player won the game
            //if (playerTurn == 1)
            //{
            //    Console.WriteLine("Player 1 wins!");
            //}
            //else
            //{
            //    Console.WriteLine("Player 2 wins!");
            //}
            Console.WriteLine($"Player {playerTurn} wins!");

        }
    }
}
