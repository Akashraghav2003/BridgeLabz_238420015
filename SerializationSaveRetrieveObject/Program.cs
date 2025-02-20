using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SerializationSaveRetrieveObject
{
    class Program
    {

        const string filePath = "employees.json";
        static void SerializeEmployees(List<Employee> employees)
        {
            try
            {
                string json = JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
                Console.WriteLine("Employees serialized successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error serializing employees: " + ex.Message);
            }
        }

        static List<Employee> DeserializeEmployees()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File not found.");
                    return new List<Employee>();
                }
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Employee>>(json) ?? new List<Employee>();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deserializing employees: " + ex.Message);
                return new List<Employee>();
            }
        }

        static void Main()
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int numEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < numEmployees; i++)
            {
                Employee emp = new Employee();
                Console.Write("Enter ID: ");
                emp.Id = int.Parse(Console.ReadLine());
                Console.Write("Enter Name: ");
                emp.Name = Console.ReadLine();
                Console.Write("Enter Department: ");
                emp.Department = Console.ReadLine();
                Console.Write("Enter Salary: ");
                emp.Salary = double.Parse(Console.ReadLine());
                employees.Add(emp);
            }

            SerializeEmployees(employees);
            List<Employee> deserializedEmployees = DeserializeEmployees();

            Console.WriteLine("\nDeserialized Employees:");
            foreach (var emp in deserializedEmployees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
            }
        }

    }
}
