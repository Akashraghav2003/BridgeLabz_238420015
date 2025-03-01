using System;
using System.IO;

namespace FileHandling
{
    public class FileProcessor
    {
        // Writes content to a file, creates the file if it does not exist
        public void WriteToFile(string filename, string content)
        {
            if (string.IsNullOrEmpty(filename))
                throw new ArgumentException("Filename cannot be null or empty");

            File.WriteAllText(filename, content);
        }

        // Reads content from a file, throws an exception if the file does not exist
        public string ReadFromFile(string filename)
        {
            if (!File.Exists(filename))
                throw new FileNotFoundException($"File not found: {filename}");

            return File.ReadAllText(filename);
        }
    }
}
