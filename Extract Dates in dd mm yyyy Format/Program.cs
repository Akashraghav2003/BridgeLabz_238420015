using System;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void ExtractDates(string text)
    {
        string pattern = @"\b(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{4}\b";

        MatchCollection matches = Regex.Matches(text, pattern);

        string[] dates = matches.Cast<Match>().Select(m => m.Value).ToArray();

        Console.WriteLine(string.Join(", ", dates));
    }

    static void Main()
    {
        string inputText = "The events are scheduled for 12/05/2023, 16/04/2024, and 29/02/2020.";

        Console.WriteLine("Extracted Dates:");
        ExtractDates(inputText);
    }
}
