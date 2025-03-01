using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using System.Linq;
using System.Formats.Asn1;

namespace RemoveDuplicates
{

    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\employees.csv"; // CSV file path
            string tempFilePath = @"D:\employees_cleaned.csv"; // New file without duplicates

            if (!File.Exists(filePath))
            {
                Console.WriteLine("CSV file not found!");
                return;
            }

            HashSet<int> seenIds = new HashSet<int>(); // Store unique IDs
            List<Employee> uniqueRecords = new List<Employee>(); // Store unique records

            // Read CSV file and remove duplicates
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.Read();
                csv.ReadHeader(); // Read header row
                var header = csv.HeaderRecord; // Store header row

                while (csv.Read())
                {
                    Employee emp = csv.GetRecord<Employee>();

                    if (seenIds.Add(emp.Id)) // Only add if ID is unique
                    {
                        uniqueRecords.Add(emp);
                    }
                }
            }

            // Write back only unique records to a new CSV file
            using (var writer = new StreamWriter(tempFilePath))
            using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.WriteRecords(uniqueRecords);
            }

            // Replace original file with cleaned file
            File.Delete(filePath);
            File.Move(tempFilePath, filePath);

            Console.WriteLine($"Duplicates removed. Updated file saved at: {filePath}");
        }
    }
}
