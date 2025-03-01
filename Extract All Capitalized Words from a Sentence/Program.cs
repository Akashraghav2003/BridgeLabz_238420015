using System;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void ExtractCapitalizedWords(string text)
    {
        string pattern = @"\b[A-Z][a-z]*\b";

        MatchCollection matches = Regex.Matches(text, pattern);

        string[] capitalizedWords = matches.Cast<Match>().Select(m => m.Value).ToArray();

        Console.WriteLine(string.Join(", ", capitalizedWords));
    }

    static void Main()
    {
        string inputText = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";

        Console.WriteLine("Extracted Capitalized Words:");
        ExtractCapitalizedWords(inputText);
    }
}
