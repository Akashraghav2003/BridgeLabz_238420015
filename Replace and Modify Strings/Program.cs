using System;
using System.Text.RegularExpressions;

class Program
{
    static void ReplaceMultipleSpaces(string text)
    {
        string pattern = @"\s+";  // Matches one or more spaces
        string replacement = " "; // Replaces with a single space

        string result = Regex.Replace(text, pattern, replacement);

        Console.WriteLine(result);
    }

    static void Main()
    {
        string inputText = "This  is   an example    with  multiple    spaces.";

        Console.WriteLine("Modified String:");
        ReplaceMultipleSpaces(inputText);
    }
}
