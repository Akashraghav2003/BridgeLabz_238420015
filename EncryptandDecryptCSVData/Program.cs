using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace EncryptDecryptCSV
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }  // Sensitive field
        public string Department { get; set; }
        public string Salary { get; set; } // Encrypted field
    }

    class Program
    {
        private static readonly string encryptionKey = "YourSecretKey123"; // Must be 16/24/32 bytes

        static void Main(string[] args)
        {
            string csvFilePath = @"D:\employees.csv";

            // Sample data
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice", Email = "alice@example.com", Department = "IT", Salary = Encrypt("60000") },
                new Employee { Id = 2, Name = "Bob", Email = "bob@example.com", Department = "HR", Salary = Encrypt("55000") },
                new Employee { Id = 3, Name = "Charlie", Email = "charlie@example.com", Department = "Finance", Salary = Encrypt("70000") }
            };

            // Write Encrypted Data to CSV
            WriteEncryptedCsv(csvFilePath, employees);

            // Read and Decrypt Data from CSV
            ReadDecryptedCsv(csvFilePath);
        }

        // ✅ Write Encrypted CSV
        static void WriteEncryptedCsv(string filePath, List<Employee> employees)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.WriteRecords(employees);
            }
            Console.WriteLine("Encrypted CSV file saved successfully.");
        }

        // ✅ Read and Decrypt CSV
        static void ReadDecryptedCsv(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                var employees = csv.GetRecords<Employee>().ToList();

                // Decrypt Salary & Email
                foreach (var emp in employees)
                {
                    emp.Salary = Decrypt(emp.Salary);
                    emp.Email = Decrypt(emp.Email);
                }

                // Display Decrypted Data
                Console.WriteLine("\nDecrypted Data:");
                foreach (var emp in employees)
                {
                    Console.WriteLine($"{emp.Id}, {emp.Name}, {emp.Email}, {emp.Department}, {emp.Salary}");
                }
            }
        }

        // 🔐 Encrypt a String
        static string Encrypt(string plainText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(encryptionKey);
                aes.IV = new byte[16];

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (MemoryStream ms = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                using (StreamWriter writer = new StreamWriter(cs))
                {
                    writer.Write(plainText);
                }
                return Convert.ToBase64String(ms.ToArray());
            }
        }

        // 🔓 Decrypt a String
        static string Decrypt(string encryptedText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(encryptionKey);
                aes.IV = new byte[16];

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(encryptedText)))
                using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (StreamReader reader = new StreamReader(cs))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
