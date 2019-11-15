using System;
using System.IO;    // for StreamWriter class

namespace FileWriteDemo
{
    class Program
    {
        // This program writes the following names to a file: Larry, Curly, Moe
        // where each name is written on a separate line
        static void Main(string[] args)
        {
            string[] names = { "Larry", "Curly", "Moe" };
            string filename = @"C:\Intel\FriendList.csv";
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach(string currentName in names)
                    {
                        writer.WriteLine(currentName);
                    }
                }
                Console.WriteLine("Write to file was successful");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"The file {filename} could not be written to.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
