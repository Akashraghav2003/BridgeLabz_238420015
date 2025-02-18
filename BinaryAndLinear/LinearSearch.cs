using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryAndLinear
{
    internal class LinearSearch
    {
        // Function to find the first missing positive integer using Linear Search
        public static int FindFirstMissingPositive(int[] arr)
        {
            int n = arr.Length;

            // Step 1: Marking elements as visited
            for (int i = 0; i < n; i++)
            {
                while (arr[i] > 0 && arr[i] <= n && arr[arr[i] - 1] != arr[i])
                {
                    // Swap arr[i] with arr[arr[i] - 1]
                    int temp = arr[i];
                    arr[i] = arr[temp - 1];
                    arr[temp - 1] = temp;
                }
            }

            // Step 2: Finding the first missing positive integer
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != i + 1)
                    return i + 1;
            }

            return n + 1; // If all numbers from 1 to n are present, return n+1
        }

        // Function to perform Binary Search for a target value
        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                    return mid; // Return index if target found
                else if (arr[mid] < target)
                    left = mid + 1; // Search in the right half
                else
                    right = mid - 1; // Search in the left half
            }

            return -1; // Return -1 if target not found
        }
    }
}
