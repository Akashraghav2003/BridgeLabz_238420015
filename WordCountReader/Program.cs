using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "D:\\akash gla university\\capgemini problem\\feature15-02-2025\\sample.txt";  // Specify the path to your file
        string wordToCount = "is";  // Specify the word to count
        int count = 0;

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Count the occurrences of the word in the line
                    int wordCountInLine = CountWordOccurrences(line, wordToCount);
                    count += wordCountInLine;
                }
            }

            Console.WriteLine($"The word '{wordToCount}' appeared {count} times in the file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    // Method to count occurrences of a word in a line
    static int CountWordOccurrences(string line, string word)
    {
        int wordCount = 0;
        int wordLength = word.Length;

        // Loop through the line and check for occurrences of the word
        for (int i = 0; i <= line.Length - wordLength; i++)
        {
            if (line.Substring(i, wordLength).Equals(word, StringComparison.OrdinalIgnoreCase))
            {
                wordCount++;
            }
        }

        return wordCount;
    }
}
