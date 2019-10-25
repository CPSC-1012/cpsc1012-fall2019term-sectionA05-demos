using System;

namespace PassByValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 99;
            Console.WriteLine($"Number is {number}");
            ChangeMe(number);
            Console.WriteLine($"Number is {number}");
        }

        static void ChangeMe(int myValue)
        {
            Console.WriteLine("I am changing the value.");
            myValue = 0;
            Console.WriteLine($"Now the value is {myValue}");
        }
    }
}
