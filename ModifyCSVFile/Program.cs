using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

namespace ModifyCSVFile
{
   

    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\employees.csv";  // Path to the CSV file

            if (!File.Exists(filePath))
            {
                Console.WriteLine("CSV file does not exist.");
                return;
            }

            List<Employee> employees;

            // Read CSV file
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                employees = new List<Employee>(csv.GetRecords<Employee>());
            }

            // Manually sort using Bubble Sort (Descending Order)
            for (int i = 0; i < employees.Count - 1; i++)
            {
                for (int j = 0; j < employees.Count - i - 1; j++)
                {
                    if (employees[j].Salary < employees[j + 1].Salary)
                    {
                        // Swap the two elements
                        Employee temp = employees[j];
                        employees[j] = employees[j + 1];
                        employees[j + 1] = temp;
                    }
                }
            }

            // Print top 5 highest-paid employees
            Console.WriteLine("Top 5 Highest-Paid Employees:");
            Console.WriteLine("ID\tName\tDepartment\tSalary");

            for (int i = 0; i < Math.Min(5, employees.Count); i++)
            {
                Console.WriteLine($"{employees[i].Id}\t{employees[i].Name}\t{employees[i].Department}\t{employees[i].Salary}");
            }
        }
    }
}
