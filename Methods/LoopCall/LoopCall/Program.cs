using System;

namespace LoopCall
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Main method");
            // Call the DisplayMessage method 5 times.
            for (int count = 1; count <= 5; count += 1)
            {
                DisplayMessage();
            }
            Console.WriteLine("Back in the Main method");
        }

        // Define a void method name DisplayMessage that
        // prints a greeting message to the Console
        static void DisplayMessage()
        {
            Console.WriteLine("Hello from DisplayMessage method.");
        }
    }
}
