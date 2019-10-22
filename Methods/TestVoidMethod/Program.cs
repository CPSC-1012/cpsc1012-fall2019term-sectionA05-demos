using System;

namespace TestVoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call the PrintGrade method with 79.5 as argument for the score
            PrintGrade(79.5);
            // Call the PrintGrade method with 59.5 as argument for the score
            PrintGrade(59.5);
            PrintGrade(105);
            PrintGrade(-5);
            PrintGrade(49.99);
        }

        // Define a void method named PrintGrade that takes in a
        // parameter with a score value and then print the grade letter
        // associated with that score according the following table:
        //  score   grade
        //  -----   ------
        //  80-100  A
        //  70-79   B
        //  60-69   C
        //  50-59   D
        //  0-49    F
        static void PrintGrade(double score)
        {
            if (score >= 80 && score <= 100)
            {
                Console.WriteLine($"{score} is a A");
            }
            else if(score >= 70)
            {
                Console.WriteLine($"{score} is a B");
            }
            else if (score >= 60)
            {
                Console.WriteLine($"{score} is a C");
            }
            else if (score >= 50)
            {
                Console.WriteLine($"{score} is a D");
            }
            else if (score >= 0)
            {
                Console.WriteLine($"{score} is a F");
            }
            else
            {
                Console.WriteLine("Invalid score value, it is not between 0-100");
            }
        }

    }
}
