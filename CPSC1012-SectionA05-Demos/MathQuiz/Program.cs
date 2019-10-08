using System;

namespace MathQuiz
{
    // A menu-driven math quiz game for the user to select math question
    // (addition, subtraction, multiplication, or division)
    // to answer
    class Program
    {
        static void Main(string[] args)
        {
            char menuChoice;
            string userInput;

            do
            {
                // Display a menu of choices.
                Console.WriteLine("-------------");
                Console.WriteLine("| Math Quiz |");
                Console.WriteLine("-------------");
                Console.WriteLine("a) Addition Question");
                Console.WriteLine("s) Subtraction Question");
                Console.WriteLine("m) Multiplication Question");
                Console.WriteLine("d) Division Question");
                Console.WriteLine("q) Quit Program");
                Console.Write("Your choice > ");
                // Process the menu choice
                userInput = Console.ReadLine();
                menuChoice = char.Parse(userInput);
                switch (menuChoice)
                {
                    case 'a':
                    case 'A':
                        Console.WriteLine("Addition Question Selected");
                        break;
                    case 's':
                    case 'S':
                        Console.WriteLine("Subtraction Question Selected");
                        break;
                    case 'm':
                    case 'M':
                        Console.WriteLine("Multiplication Question Selected");
                        break;
                    case 'd':
                    case 'D':
                        Console.WriteLine("Division Question Selected");
                        break;
                    case 'q':
                    case 'Q':
                        break;
                    default:
                        Console.WriteLine("Invalid menu choice. Try again.");
                        break;
                }
                // Loop until the menu choice is either the character 'q' or 'Q'
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            } while (menuChoice != 'q' && menuChoice != 'Q');

            

            Console.WriteLine("Thanks for using this program. Good-bye.");
        }
    }
}
