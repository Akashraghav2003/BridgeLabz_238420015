using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = @"D:\akash gla university\capgemini problem\feature20-02-2025\ReadLargeFileLineByLine\largeFile.txt"; 

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}