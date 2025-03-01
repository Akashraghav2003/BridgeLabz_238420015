using System;
using System.IO;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void ExtractEmails(string text)
    {
        string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }

    static void Main()
    {
        string inputText = "Contact us at support@example.com and info@company.org  and ishwarmars@gmail.com for more details.";

        Console.WriteLine("Extracted Email Addresses:");
        ExtractEmails(inputText);
    }
}
