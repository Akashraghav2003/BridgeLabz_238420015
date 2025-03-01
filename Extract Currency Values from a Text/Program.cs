using System;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void ExtractCurrencyValues(string text)
    {
        string pattern = @"\$\s?\d+(\.\d{2})?"; // Matches "$45.99", "$ 10.50"

        MatchCollection matches = Regex.Matches(text, pattern);
        string[] extractedValues = matches.Cast<Match>().Select(m => m.Value.Replace(" ", "")).ToArray();

        Console.WriteLine(string.Join(", ", extractedValues));
    }

    static void Main()
    {
        string inputText = "The price is $45.99, and the discount is $ 10.50.";

        Console.WriteLine("Extracted Currency Values:");
        ExtractCurrencyValues(inputText);
    }
}
