using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    internal class Heap
    {
        public static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;   // Assume root is the largest
            int left = 2 * i + 1;  // Left child index
            int right = 2 * i + 2; // Right child index

            // If left child is larger than root
            if (left < n && arr[left] > arr[largest])
                largest = left;

            // If right child is larger than largest so far
            if (right < n && arr[right] > arr[largest])
                largest = right;

            // If largest is not root, swap and continue heapifying
            if (largest != i)
            {
                Swap(arr, i, largest);
                Heapify(arr, n, largest);
            }
        }

        // Function to perform Heap Sort
        public static void HeapSortAlgo(int[] arr)
        {
            int n = arr.Length;

            // Step 1: Build Max Heap
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            // Step 2: Extract elements from heap one by one
            for (int i = n - 1; i > 0; i--)
            {
                // Move current root (largest) to end
                Swap(arr, 0, i);

                // Heapify the reduced heap
                Heapify(arr, i, 0);
            }
        }

        // Swap function to exchange elements
        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        public void Display(int[] arr)
        {
            int len = arr.Length;

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(arr[i] + "");
            }
        }
    }
}
