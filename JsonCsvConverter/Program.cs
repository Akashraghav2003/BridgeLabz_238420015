using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Xml;
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;

namespace JsonCsvConverter
{
    

    class Program
    {
        static void Main(string[] args)
        {
            string jsonFilePath = @"D:\students.json";
            string csvFilePath = @"D:\students.csv";
            string jsonOutputFilePath = @"D:\students_converted.json";

            // Convert JSON to CSV
            ConvertJsonToCsv(jsonFilePath, csvFilePath);

            // Convert CSV back to JSON
            ConvertCsvToJson(csvFilePath, jsonOutputFilePath);
        }

        // ✅ Convert JSON to CSV
        static void ConvertJsonToCsv(string jsonFilePath, string csvFilePath)
        {
            if (!File.Exists(jsonFilePath))
            {
                Console.WriteLine("JSON file not found!");
                return;
            }

            string jsonData = File.ReadAllText(jsonFilePath);
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(jsonData);

            using (var writer = new StreamWriter(csvFilePath))
            using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.WriteRecords(students);
            }

            Console.WriteLine($"JSON converted to CSV: {csvFilePath}");
        }

        // ✅ Convert CSV to JSON
        static void ConvertCsvToJson(string csvFilePath, string jsonOutputFilePath)
        {
            if (!File.Exists(csvFilePath))
            {
                Console.WriteLine("CSV file not found!");
                return;
            }

            List<Student> students;

            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                students = new List<Student>(csv.GetRecords<Student>());
            }

            string jsonData = JsonConvert.SerializeObject(students, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(jsonOutputFilePath, jsonData);

            Console.WriteLine($"CSV converted back to JSON: {jsonOutputFilePath}");
        }
    }
}
