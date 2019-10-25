using System;

namespace DeepAndDeeper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am starting in Main method.");
            Deep();
            Console.WriteLine("Now I am back in Main method.");
        }

        static void Deep()
        {
            Console.WriteLine("I am now in Deep method.");
            Deeper();
            Console.WriteLine("Now I am back in Deep method.");
        }

        static void Deeper()
        {
            Console.WriteLine("I am now in Deeper method.");
        }
    }
}
