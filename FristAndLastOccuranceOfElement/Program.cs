namespace FristAndLastOccuranceOfElement
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter the sorted array elements:");

            // Taking sorted array input from the user
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Input the target element to search for
            Console.Write("Enter the target value to search: ");
            int target = Convert.ToInt32(Console.ReadLine());

            // Finding first and last occurrences using binary search
            int first = FristLastOccurance.FindFirst(arr, target);
            int last = FristLastOccurance.FindLast(arr, target);

            // Displaying the result
            if (first != -1)
                Console.WriteLine($"First occurrence of {target}: {first}\nLast occurrence of {target}: {last}");
            else
                Console.WriteLine("Target not found in the array.");
        }
    }
}