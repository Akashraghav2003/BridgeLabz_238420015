using System;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void ExtractLinks(string text)
    {
        string pattern = @"\bhttps?:\/\/[^\s/$.?#].[^\s]*";

        MatchCollection matches = Regex.Matches(text, pattern);

        string[] links = matches.Cast<Match>().Select(m => m.Value).ToArray();

        Console.WriteLine(string.Join(", ", links));
    }

    static void Main()
    {
        string inputText = "Visit https://www.google.com and http://example.org for more info.";

        Console.WriteLine("Extracted Links:");
        ExtractLinks(inputText);
    }
}
