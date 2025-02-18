namespace PeakElementInArray
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter the {i} element: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int peakIndex = FindPeakElement.PeakElement(arr);
            Console.WriteLine("The peak element is at index: " + peakIndex + " (Value: " + arr[peakIndex] + ")");
        }
    
    }
}