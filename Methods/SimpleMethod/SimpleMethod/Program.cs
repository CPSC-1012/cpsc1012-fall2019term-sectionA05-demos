using System;

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Main method");
            // Call (execute) the DisplayMessage method
            DisplayMessage();
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
