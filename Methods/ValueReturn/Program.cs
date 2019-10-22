using System;

namespace ValueReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            int total,
                    value1 = 20,
                    value2 = 40;
            // Call the Sum method, passing in the contents of value1 and value2
            // as arguments. Assign the return value in the total variable.
            total = Sum(value1, value2);
            // Display the contents of all variables
            Console.WriteLine($"{value1} + {value2} = {total}");
        }

        // Define a method named Sum that takes in two integer numbers and
        // returns the sum of the two integer numbers
        static int Sum(int num1, int num2)
        {
            int result;
            result = num1 + num2;
            // return the value in the the result variable
            return result;
        }
    }
}
