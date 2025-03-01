using System;
using CsvHelper;
using CsvHelper.Configuration;
using System.IO;
using CsvHelper.Configuration.Attributes;
using System.Globalization;

namespace ReadCSV
{
	class Program
	{
        static void Main(string[] args)
        {
            string path = @"D:\akash gla university\capgemini problem\feature25-02-2025\Employee.csv";

            int rows = 0;

            using(var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.Read();
                csv.ReadHeader();

                while (csv.Read())
                {
                    rows++;
                }
            }

            Console.WriteLine($"Total number of Rows: {rows}");
        }
    }
}
