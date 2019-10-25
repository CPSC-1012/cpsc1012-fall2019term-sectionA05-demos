﻿using System;

namespace PassArg
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            Console.WriteLine("I am passing values to DisplayValue");
            DisplayValue(5);                // Pass 5
            DisplayValue(num1);             // Pass 10
            DisplayValue(num1 * 4);         // Pass 40
            DisplayValue(int.Parse("700")); // Pass 700
            Console.WriteLine("That's all");
        }

        // Display the value of its integer parameter
        static void DisplayValue(int num)
        {
            Console.WriteLine($"The value is {num}");
        }
    }
}
