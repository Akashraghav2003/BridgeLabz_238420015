using System;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

namespace SearchCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\employees.csv"; 

            if (!File.Exists(filePath))
            {
                Console.WriteLine("CSV file does not exist.");
                return;
            }

            Console.Write("Enter the employee name to search: ");
            string searchName = Console.ReadLine();

            bool found = false;

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.Read();
                csv.ReadHeader();

                while (csv.Read())
                {
                    string name = csv.GetField("Name");

                    if (name.Equals(searchName, StringComparison.OrdinalIgnoreCase)) // Case-insensitive search
                    {
                        string department = csv.GetField("Department");
                        double salary = csv.GetField<double>("Salary");

                        Console.WriteLine($"Employee Found!");
                        Console.WriteLine($"Department: {department}");
                        Console.WriteLine($"Salary: {salary}");
                        found = true;
                        break; // Stop searching after finding the first match
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("Employee not found.");
            }
        }
    }
}
