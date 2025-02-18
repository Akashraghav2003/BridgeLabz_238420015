using System;
using System.IO;

class BinaryTextFileToText
{
    static void Main()
    {
        string filePath = "D:\\akash gla university\\capgemini problem\\feature15-02-2025\\sample.bin"; // File containing binary string

        try
        {
            // Read binary text from file and trim whitespace
            string binaryString = File.ReadAllText(filePath).Trim();

            // Split the binary string into 8-bit chunks, ignoring empty entries
            string[] binaryValues = binaryString.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            string text = "";

            foreach (string binary in binaryValues)
            {
                if (binary.Length == 8)  // Ensure each binary number is 8 bits
                {
                    int decimalValue = Convert.ToInt32(binary, 2); // Convert binary to decimal
                    text += (char)decimalValue; // Convert decimal to character
                }
            }

            Console.WriteLine("Converted Text: " + text);
        }
        catch (IOException e)
        {
            Console.WriteLine("Error reading file: " + e.Message);
        }
    }
}