using System;
using System.IO;

namespace FileReadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\Intel\FriendList.csv";
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    String line;
                    while ( (line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("Finished reading from file.");
                }
            } 
            catch(Exception ex)
            {
                Console.WriteLine($"The file {filename} could be read.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
