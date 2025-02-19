namespace WordFrequencyCounter
{
	class Program
	{
        static void Main()
        {
            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine();

            Dictionary<string, int> wordFrequencies =CountFrequency.CountWordFrequency(filePath);

            Console.WriteLine("Word Frequencies:");
            foreach (var pair in wordFrequencies)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}