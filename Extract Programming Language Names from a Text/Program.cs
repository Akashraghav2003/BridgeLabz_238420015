using System;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void ExtractProgrammingLanguages(string text)
    {
        string[] languages = { "Java", "Python", "JavaScript", "C", "C++", "C#", "Go", "Swift", "Ruby", "Kotlin", "PHP", "Rust", "TypeScript" };
        string pattern = @"\b(" + string.Join("|", languages.Select(Regex.Escape)) + @")\b";

        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);
        string[] extractedLanguages = matches.Cast<Match>().Select(m => m.Value).Distinct().ToArray();

        Console.WriteLine(string.Join(", ", extractedLanguages));
    }

    static void Main()
    {
        string inputText = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";

        Console.WriteLine("Extracted Programming Languages:");
        ExtractProgrammingLanguages(inputText);
    }
}
