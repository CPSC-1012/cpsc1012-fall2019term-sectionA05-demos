using System;

namespace SSPE01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            double salary;
            string userInput;

            // Prompt and read in the name
            Console.WriteLine("Enter your name:");
            userInput = Console.ReadLine();
            // copy the userInput value to name
            name = userInput;

            // Prompt and read in the age
            Console.WriteLine("Enter your age: ");
            userInput = Console.ReadLine();
            // Convert the userInput into an integer value
            age = int.Parse(userInput);

            // Prompt and read in the salary
            Console.WriteLine("Enter your salary: ");
            userInput = Console.ReadLine();
            // Conver the userInput into a double value
            salary = double.Parse(userInput);

            //Console.WriteLine("My name is Don Iveson, my age is 45 and I hope to earn $204,747.00 per year");
            // Display a message using "String Concatentation" using the + operator
            Console.WriteLine("My name is " + name
                + " my age is " + age
                + " and I hope to earn " + string.Format("{0:C}",salary)
                + " per year");
            // Display a message using "String Formatting" using {#} as a placeholder
            Console.WriteLine("My name is {0}, my age is {1} and I hope to earn {2:C} per year.",
                name, age, salary );
            // Display a message using "String Interpolation" where $"" represents a interpolated string
            Console.WriteLine($"My name is {name}, my age is {age} and I hope to earn {salary:C} per year.");

        }
    }
}
