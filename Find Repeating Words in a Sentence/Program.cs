using System;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void FindRepeatingWords(string text)
    {
        string pattern = @"\b(\w+)\s+\1\b"; // Captures repeated words
        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

        string[] repeatedWords = matches.Cast<Match>().Select(m => m.Groups[1].Value).Distinct().ToArray();

        Console.WriteLine(string.Join(", ", repeatedWords));
    }

    static void Main()
    {
        string inputText = "This is is a repeated repeated word test.";

        Console.WriteLine("Repeating Words:");
        FindRepeatingWords(inputText);
    }
}
