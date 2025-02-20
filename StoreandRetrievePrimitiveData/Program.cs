using System;
using System.IO;
class StudentData
{
    static void Main()
    {
        string filePath = "studentData.bin";
        Console.Write("Enter Roll Number: ");
        int rollNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter GPA: ");
        double gpa = double.Parse(Console.ReadLine());

        // Writing student details to binary file
        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            writer.Write(rollNumber);
            writer.Write(name);
            writer.Write(gpa);
        }

        Console.WriteLine("Student details written to file.");

        // Reading student details from binary file
        using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
        {
            int storedRollNumber = reader.ReadInt32();
            string storedName = reader.ReadString();
            double storedGpa = reader.ReadDouble();

            Console.WriteLine("Student Details:");
            Console.WriteLine($"Roll Number: {storedRollNumber}");
            Console.WriteLine($"Name: {storedName}");
            Console.WriteLine($"GPA: {storedGpa}");
        }
    }

}
