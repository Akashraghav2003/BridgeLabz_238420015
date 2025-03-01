using System;
using CsvHelper;
using CsvHelper.Configuration;
using System.IO;
using System.Globalization;
using System.Collections;

namespace WriteData
{
	class Program
	{
        static void Main(string[] args)
        {
            string path = "Employee.csv";

            if (!File.Exists(path))
            {
                Console.WriteLine("File does not exits. Creating File...");
                var employee = new List<Employee>();
                while(true)
                {
                    Console.WriteLine("Choose the operation: ");
                    Console.WriteLine(" 1.add new employee \n 2.Exits");
                    int operaqtion = Convert.ToInt32(Console.ReadLine());

                    switch(operaqtion)
                    {
                        case 1:
                            Console.WriteLine("Enter the Id: ");
                            int Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the name: ");
                            string Name = Console.ReadLine();
                            Console.WriteLine("Enter the Department: ");
                            string Department = Console.ReadLine();
                            Console.WriteLine("Enter the Salary:");
                            double salary = Convert.ToDouble(Console.ReadLine());

                            Employee emplo = new Employee(Id, Name, Department, salary);
                            employee.Add(emplo);
                            break;
                        
                    }
                    if (operaqtion == 2)
                        break;
                }
                
                using (var writer = new StreamWriter(path))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csv.WriteRecords(employee);
                }
                Console.WriteLine("Add data");

            }
            else
            {
                Console.WriteLine("File allrady exits");
            }
           
        }
    }
}
