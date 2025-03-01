using System;
using System.Text.RegularExpressions;

class Program
{
    static void CensorBadWords(string text, string[] badWords)
    {
        string pattern = @"\b(" + string.Join("|", badWords) + @")\b"; // Matches full bad words
        string replacement = "****";

        string result = Regex.Replace(text, pattern, replacement, RegexOptions.IgnoreCase);

        Console.WriteLine(result);
    }

    static void Main()
    {
        string inputText = "This is a damn bad example with some stupid words.";
        string[] badWords = { "damn", "stupid" }; // List of bad words

        Console.WriteLine("Censored Sentence:");
        CensorBadWords(inputText, badWords);
    }
}
