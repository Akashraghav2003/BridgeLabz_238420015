using System.Diagnostics;

namespace CompareBinaryLinearSearch
{
	class Program
	{
        static void Main()
        {
            int[] datasetSizes = { 1000, 10000, 1000000 }; // Different dataset sizes
            Random rand = new Random();

            foreach (int size in datasetSizes)
            {
                int[] arr = new int[size];

                // Generating sorted dataset
                for (int i = 0; i < size; i++)
                    arr[i] = i + 1;

                int target = rand.Next(1, size); // Random target within the dataset

                // Measure Linear Search time using DateTime
                long startTime = DateTime.Now.Ticks;
                SearchComaprison.LinearSearch(arr, target);
                long linearTime = DateTime.Now.Ticks - startTime; // Time taken in ticks

                // Measure Binary Search time using DateTime
                startTime = DateTime.Now.Ticks;
                SearchComaprison.BinarySearch(arr, target);
                long binaryTime = DateTime.Now.Ticks - startTime; // Time taken in ticks

                Console.WriteLine($"Dataset Size: {size}");
                Console.WriteLine($"Linear Search Time: {linearTime} ticks");
                Console.WriteLine($"Binary Search Time: {binaryTime} ticks\n");
            }
        }
    }
}