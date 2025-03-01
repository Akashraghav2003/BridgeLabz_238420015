using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

namespace LargeCSVReader
{
    public class DataRecord
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\large_data.csv"; // Path to large CSV file
            int batchSize = 100; // Number of records to read at a time
            int totalRecordsProcessed = 0;

            if (!File.Exists(filePath))
            {
                Console.WriteLine("CSV file not found!");
                return;
            }

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.Read();
                csv.ReadHeader(); // Read the header first

                List<DataRecord> batch = new List<DataRecord>();

                while (csv.Read())
                {
                    DataRecord record = csv.GetRecord<DataRecord>();
                    batch.Add(record);

                    if (batch.Count >= batchSize)
                    {
                        // Process the current batch
                        ProcessBatch(batch);
                        totalRecordsProcessed += batch.Count;
                        batch.Clear();
                    }
                }

                // Process any remaining records
                if (batch.Count > 0)
                {
                    ProcessBatch(batch);
                    totalRecordsProcessed += batch.Count;
                }
            }

            Console.WriteLine($"Total records processed: {totalRecordsProcessed}");
        }

        static void ProcessBatch(List<DataRecord> batch)
        {
            Console.WriteLine($"Processing {batch.Count} records...");
            // Simulate processing
            System.Threading.Thread.Sleep(500); // Delay to simulate work
        }
    }
}
