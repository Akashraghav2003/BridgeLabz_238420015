namespace InvertMap
{
	class Program
	{
        static void Main(string[] args)
        {
            Dictionary<string, int> input = new Dictionary<string, int>
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 1 }
        };

            Dictionary<int, List<string>> output =DictionaryInverter.InvertDictionary(input);

            Console.WriteLine("Inverted Dictionary:");
            foreach (var pair in output)
            {
                Console.WriteLine($"{pair.Key}: [{string.Join(", ", pair.Value)}]");
            }
        }
    }
}