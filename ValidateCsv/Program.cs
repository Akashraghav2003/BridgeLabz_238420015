using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using CsvHelper;
using CsvHelper.Configuration;

namespace ValidateCsv
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
            List<Employee> invalidRecords = new List<Employee>();

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Regex for email validation
            string phonePattern = @"^\d{10}$"; // Regex for 10-digit phone number

            // Read CSV file
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                employees = new List<Employee>(csv.GetRecords<Employee>());
            }

            // Validate records
            foreach (var employee in employees)
            {
                bool isValidEmail = Regex.IsMatch(employee.Email, emailPattern);
                bool isValidPhone = Regex.IsMatch(employee.PhoneNumber, phonePattern);

                if (!isValidEmail || !isValidPhone)
                {
                    invalidRecords.Add(employee);
                }
            }

            // Print invalid records
            if (invalidRecords.Count > 0)
            {
                Console.WriteLine("Invalid Records Found:");
                Console.WriteLine("ID\tName\tEmail\t\t\tPhoneNumber\tError");

                foreach (var emp in invalidRecords)
                {
                    string emailError = Regex.IsMatch(emp.Email, emailPattern) ? "" : "Invalid Email";
                    string phoneError = Regex.IsMatch(emp.PhoneNumber, phonePattern) ? "" : "Invalid Phone Number";

                    Console.WriteLine($"{emp.Id}\t{emp.Name}\t{emp.Email}\t{emp.PhoneNumber}\t{emailError} {phoneError}");
                }
            }
            else
            {
                Console.WriteLine("All records are valid!");
            }
        }
    }
}
