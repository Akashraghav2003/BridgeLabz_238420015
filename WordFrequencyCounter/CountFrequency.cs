using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordFrequencyCounter
{
    internal class CountFrequency
    {
        public static Dictionary<string, int> CountWordFrequency(string filePath)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found!");
                return wordCount;
            }

            string text = File.ReadAllText(filePath).ToLower();
            string[] words = Regex.Split(text, @"\W+"); // Split by non-word characters

            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    if (wordCount.ContainsKey(word))
                        wordCount[word]++;
                    else
                        wordCount[word] = 1;
                }
            }
            return wordCount;
        }

    }
}
