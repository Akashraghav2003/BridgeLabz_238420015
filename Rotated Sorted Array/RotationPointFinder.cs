using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotated_Sorted_Array
{
    internal class RotationPointFinder
    {
        public  int FindRotationPoint(int[] arr)
        {
            int left = 0, right = arr.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                // If mid element is greater than the last element, rotation point is on the right side
                if (arr[mid] > arr[right])
                    left = mid + 1;
                else
                    right = mid; // Rotation point could be mid, so include mid in search
            }

            return left; // Left will point to the smallest element (rotation point)
        }
    }
}
