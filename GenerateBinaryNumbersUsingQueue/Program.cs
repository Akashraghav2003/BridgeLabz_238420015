namespace GenerateBinaryNumbersUsingQueue
{
	class Program
	{
        static void Main()
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());

            List<string> binaryNumbers =BinaryNumberGenerator.GenerateBinaryNumbers(N);

            Console.WriteLine("Binary Numbers:");
            Console.WriteLine("{" + string.Join(", ", binaryNumbers) + "}");
        }
    }
}