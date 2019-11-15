using System;
using System.IO;
namespace FileReadDemo02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] winningNumbers = { 1, 19, 31, 44, 46, 49 };
            int bonusNumber = 3;

            string filename = @"C:\Intel\Lotto649QuickPicks.csv";
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    String line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] lineArray = line.Split(",");
                        int[] lottoNumbers = new int[lineArray.Length];
                        for (int index = 0; index < lottoNumbers.Length; index += 1)
                        {
                            lottoNumbers[index] = int.Parse(lineArray[index]);
                        }
                        int matchCount = 0;
                        
                        Console.WriteLine($"Match count: {matchCount}");
                    }
                    Console.WriteLine("Finished reading from file.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The file {filename} could be read.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
