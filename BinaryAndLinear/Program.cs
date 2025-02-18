namespace BinaryAndLinear
{
	class Program
	{
        static void Main()
        {
            // Input: List of integers
            Console.WriteLine("Enter the number of elements:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter the list of integers:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Finding the first missing positive integer
            int missingPositive =LinearSearch.FindFirstMissingPositive((int[])arr.Clone());
            Console.WriteLine($"First missing positive integer: {missingPositive}");

            // Sorting array for Binary Search
            Array.Sort(arr);
            Console.WriteLine("Sorted array for Binary Search: " + string.Join(" ", arr));

            // Input: Target number for Binary Search
            Console.Write("Enter the target number to search: ");
            int target = Convert.ToInt32(Console.ReadLine());

            // Performing Binary Search
            int targetIndex = LinearSearch.BinarySearch(arr, target);
            if (targetIndex != -1)
                Console.WriteLine($"Target {target} found at index: {targetIndex}");
            else
                Console.WriteLine("Target not found in the array.");
        }
    }
}