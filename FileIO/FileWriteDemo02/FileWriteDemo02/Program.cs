using System;
using System.IO;

namespace FileWriteDemo02
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\Intel\Lotto649QuickPicks.csv";
            Console.WriteLine("Enter number of Lotto 649 quick picks:");
            int quickPickCount = int.Parse(Console.ReadLine());
            try
            {
                using(StreamWriter writer = new StreamWriter(filename))
                {
                    for (int lottoCount = 1; lottoCount <= quickPickCount; lottoCount += 1)
                    {
                        // generate the quick pick numbers
                        int[] pickPicks = GenerateNumbers(1, 49, 6);
                        for(int index = 0;  index < pickPicks.Length; index += 1)
                        {
                            writer.Write(pickPicks[index]);
                            if (index < (pickPicks.Length -1))
                            {
                                writer.Write(",");
                            }
                        }
                        writer.WriteLine();
                    }
                    Console.WriteLine($"Finished writing to {filename}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"The {filename} could not be written to.");
                Console.WriteLine(ex.Message);
            }
                

        }

        static void SelectionSort(int[] array)
        {
            for (int index = 0; index < array.Length - 1; index += 1)
            {
                int currentSmallestValue = array[index];
                int currentSmallestIndex = index;
                for (int innerIndex = index + 1; innerIndex < array.Length; innerIndex += 1)
                {
                    if (array[innerIndex] < currentSmallestValue)
                    {
                        currentSmallestValue = array[innerIndex];
                        currentSmallestIndex = innerIndex;
                    }
                }
                // Swap numbers
                if (currentSmallestIndex != index)
                {
                    array[currentSmallestIndex] = array[index];
                    array[index] = currentSmallestValue;
                }
            }
        }

        static bool IsNumberInArray(int number, int[] array)
        {
            bool inArray = false;
            for (int index = 0; index < array.Length; index += 1)
            {
                if (number == array[index])
                {
                    inArray = true;
                    // stop looping by changed looping condition to false
                    // avoid usng break statement to get out of loop
                    index = array.Length;
                }
            }
            return inArray;
        }
        static int[] GenerateNumbers(int minValue, int maxValue, int numberCount)
        {
            int[] numberArray = new int[numberCount];
            Random rand = new Random();
            for (int index = 0; index < numberCount;)
            {
                int randomNumber = rand.Next(minValue, maxValue + 1);
                bool duplicateNumber = IsNumberInArray(randomNumber, numberArray);
                if (!duplicateNumber)
                {
                    numberArray[index] = randomNumber;
                    index += 1;
                }
            }
            SelectionSort(numberArray);
            return numberArray;
        }
    }
}
