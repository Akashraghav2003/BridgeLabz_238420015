using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

namespace MergeTwoCSVFiles
{

    class Program
    {
        static void Main(string[] args)
        {
            string file1 = @"students1.csv"; 
            string file2 = @"students2.csv"; 
            string outputFile = @"merged_students.csv"; 

            if (!File.Exists(file1) || !File.Exists(file2))
            {
                Console.WriteLine("One or both CSV files do not exist.");
                return;
            }

            // Dictionary to store merged student data
            Dictionary<int, MergedStudent> studentDictionary = new Dictionary<int, MergedStudent>();

            // Read first CSV file and add to dictionary
            using (var reader = new StreamReader(file1))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                while (csv.Read())
                {
                    int id = csv.GetField<int>("Id");
                    string name = csv.GetField<string>("Name");
                    int age = csv.GetField<int>("Age");

                    studentDictionary[id] = new MergedStudent
                    {
                        Id = id,
                        Name = name,
                        Age = age
                    };
                }
            }

            // Read second CSV file and update dictionary
            using (var reader = new StreamReader(file2))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                while (csv.Read())
                {
                    int id = csv.GetField<int>("Id");
                    double marks = csv.GetField<double>("Marks");
                    string grade = csv.GetField<string>("Grade");

                    if (studentDictionary.ContainsKey(id))
                    {
                        studentDictionary[id].Marks = marks;
                        studentDictionary[id].Grade = grade;
                    }
                }
            }

            // Write merged data to new CSV file
            using (var writer = new StreamWriter(outputFile))
            using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.WriteRecords(studentDictionary.Values);
            }

            Console.WriteLine("Merged CSV file created successfully!");
        }
    }
}
