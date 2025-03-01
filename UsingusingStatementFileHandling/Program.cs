using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "info.txt";

        try
        {
            // Using statement ensures StreamReader is disposed automatically
            using (StreamReader reader = new StreamReader(filePath))
            {
                string firstLine = reader.ReadLine();
                Console.WriteLine("First line of file: " + firstLine);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading file");
        }
    }
}
