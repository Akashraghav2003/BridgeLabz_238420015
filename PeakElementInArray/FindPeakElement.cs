using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeakElementInArray
{
    internal class FindPeakElement
    {
        public static int PeakElement(int[] arr)
        {
            int left = 0, right = arr.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                // If mid element is greater than the next element, the peak is on the left side (or mid itself)
                if (arr[mid] > arr[mid + 1])
                    right = mid;
                else
                    left = mid + 1; // Otherwise, the peak is on the right side
            }

            return left; // 'left' will point to the peak element
        }
    }
}
