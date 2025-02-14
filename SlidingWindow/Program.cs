using System;

namespace SlidingWindow
{
    class Program
    {
        static void Main(string[] args)
        {
            SlidingWindow slidingWindow = new SlidingWindow();

            Console.WriteLine("Enter the size of the array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++) arr[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the window size:");
            int windowSize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Maximum elements in each sliding window:");
            slidingWindow.Max(arr, windowSize);
        }
    }
}
