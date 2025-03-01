using System;
namespace ReadCSVFile
{
	class Program
	{
        static void Main(string[] args)
        {
            string path = @"D:\akash gla university\capgemini problem\feature25-02-2025\Employee.csv";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}