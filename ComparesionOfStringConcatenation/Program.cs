namespace ComparesionOfStringConcatenation
{
	class Program
	{
        static void Main()
        {
            int[] testSizes = { 1000, 10000, 1000000 }; // Different dataset sizes

            foreach (int size in testSizes)
            {
                Console.WriteLine($"Dataset Size: {size}");

                // Measure String concatenation time
                long stringTime = StringConcatenation.ConcatenateWithString(size);
                Console.WriteLine($"String Concatenation Time: {stringTime} ms");

                // Measure StringBuilder concatenation time
                long stringBuilderTime = StringConcatenation.ConcatenateWithStringBuilder(size);
                Console.WriteLine($"StringBuilder Concatenation Time: {stringBuilderTime} ms\n");
            }
        }
    }
}