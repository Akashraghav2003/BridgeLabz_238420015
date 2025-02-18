using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FristAndLastOccuranceOfElement
{
    internal class FristLastOccurance
    {
        public static int FindFirst(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;
            int first = -1; // Variable to store the first occurrence index

            while (left <= right)
            {
                int mid = left + (right - left) / 2; // Calculate middle index

                if (arr[mid] == target)
                {
                    first = mid;  // Store the current index as first occurrence
                    right = mid - 1; // Continue searching in the left half
                }
                else if (arr[mid] < target)
                    left = mid + 1; // Search in the right half
                else
                    right = mid - 1; // Search in the left half
            }

            return first; // Return the first occurrence index
        }
        public static int FindLast(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;
            int last = -1; // Variable to store the last occurrence index

            while (left <= right)
            {
                int mid = left + (right - left) / 2; // Calculate middle index

                if (arr[mid] == target)
                {
                    last = mid;  // Store the current index as last occurrence
                    left = mid + 1; // Continue searching in the right half
                }
                else if (arr[mid] < target)
                    left = mid + 1; // Search in the right half
                else
                    right = mid - 1; // Search in the left half
            }

            return last; // Return the last occurrence index
        }
    }
}
