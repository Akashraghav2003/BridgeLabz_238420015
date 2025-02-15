using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSort
{
    internal class CountingSort
    {
        public static void CountSort(int[] arr, int min, int max)
        {
            int range = max - min + 1;
            int[] count = new int[range];  // Count array
            int[] output = new int[arr.Length]; // Sorted output array

            // Step 1: Count occurrences of each age
            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i] - min]++;
            }

            // Step 2: Compute cumulative frequency
            for (int i = 1; i < range; i++)
            {
                count[i] += count[i - 1];
            }

            // Step 3: Place elements in correct position in output array
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                output[count[arr[i] - min] - 1] = arr[i];
                count[arr[i] - min]--;
            }

            // Copy sorted elements back to original array
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = output[i];
            }
        }
    }
}
