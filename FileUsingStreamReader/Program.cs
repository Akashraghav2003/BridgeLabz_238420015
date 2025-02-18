using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "D:\\akash gla university\\capgemini problem\\feature15-02-2025\\sample.txt"; // Output file name

        try
        {
            Console.WriteLine("Enter text to save in the file (type 'exit' to stop):");

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                while (true)
                {
                    string userInput = Console.ReadLine(); // Read user input

                    if (userInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
                        break; // Stop when user types 'exit'

                    writer.WriteLine(userInput); // Write input to file
                }
            }

            Console.WriteLine($"User input has been saved to {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
