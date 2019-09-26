using System;

namespace SSPE02
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables for storing inputs and calculated values
            double radius;
            double length;
            double area;
            double volume;
            string userInput;

            // assign sample values to inputs
            //radius = 5.5;
            //length = 12;
            // Prompt and read in the radius;
            Console.WriteLine("Enter the radius of a cylinder: ");
            userInput = Console.ReadLine();
            // Convert userInput to an double
            radius = double.Parse(userInput);

            // Prompt and read in the length;
            Console.WriteLine("Enter the length of a cylinder: ");
            userInput = Console.ReadLine();
            // Convert userInput to an double
            length = double.Parse(userInput);

            // calculate the area and volume
            area = radius * radius * Math.PI;
            volume = area * length;

            // display the area and volume
            Console.WriteLine($"The area is {area:F4}");
            Console.WriteLine($"The volume is {volume:F1}");
        }
    }
}
