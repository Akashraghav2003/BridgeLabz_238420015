namespace CompareReadFile
{
	class Program
	{
        static void Main(string[] args)
        {
            string filePath = "D:\\akash gla university\\capgemini problem\\feature15-02-2025\\sample.txt";

            Console.WriteLine("Reading large file: " + filePath);

            long streamReaderTime = ReadingComparison.ReadUsingStreamReader(filePath);
            Console.WriteLine($"StreamReader Time: {streamReaderTime} ms");

            long fileStreamTime =ReadingComparison.ReadUsingFileStream(filePath);
            Console.WriteLine($"FileStream Time: {fileStreamTime} ms");
        }
    }
}