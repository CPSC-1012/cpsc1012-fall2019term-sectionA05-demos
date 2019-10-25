using System;

namespace CreditCard
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            double annualSalary;
            int creditRating;
            // Prompt and read in the annual salary and credit rating (1-10)
            Console.Write("Enter your annual salary: ");
            userInput = Console.ReadLine();
            annualSalary = double.Parse(userInput);
            Console.Write("Enter your credit rating (1-10): ");
            userInput = Console.ReadLine();
            creditRating = int.Parse(userInput);
            // Determine if the user qualify for a credit
            // To qualify the annual salary >= 50000 and credit rating >= 7
            //if (annualSalary >= 50000)
            //{
            //    if (creditRating >= 7)
            //    {
            //        Qualify();
            //    }
            //}
            //else
            //{
            //    NotQualify();
            //}
            if (annualSalary >= 50000 && creditRating >= 7)
            {
                Qualify();
            }
            else
            {
                NotQualify();
            }

        }

        static void Qualify()
        {
            Console.WriteLine("Congratulations! You qualify for the credit card");
        }
        static void NotQualify()
        {
            Console.WriteLine("I am sorry. You do not qualify for the credit card");
        }
    }
}
