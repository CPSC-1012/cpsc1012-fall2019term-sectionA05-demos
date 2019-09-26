using System;

namespace SSPE03
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double area;
            string userInput;

            //length = 5.5;
            Console.WriteLine("Enter the length of the hexagon");
            userInput = Console.ReadLine();
            length = int.Parse(userInput);

            area = 3 * Math.Sqrt(3) * Math.Pow(length, 2) / 2;

            Console.WriteLine($"The area of the hexagon is {area:F4}");
        }
    }
}
