using System;

namespace MergeSort
{
    internal class Merge
    {
        public static void MergeSort(double[] arr, int left, int right)
        {
            if (left >= right) return; // Base case: Single element is already sorted

            int mid = left + (right - left) / 2;

            // Recursively sort left and right halves
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);

            // Merge sorted halves
            Merges(arr, left, mid, right);
        }

        public static void Merges(double[] arr, int left, int mid, int right)
        {
            int leftSize = mid - left + 1;
            int rightSize = right - mid;

            double[] leftArr = new double[leftSize];
            double[] rightArr = new double[rightSize];

            // Copy elements to left array
            for (int i = 0; i < leftSize; ++i)
                leftArr[i] = arr[left + i];

            // Copy elements to right array
            for (int j = 0; j < rightSize; ++j)
                rightArr[j] = arr[mid + 1 + j];

            int iLeft = 0, iRight = 0, k = left;

            // Merge process
            while (iLeft < leftSize && iRight < rightSize)
            {
                if (leftArr[iLeft] <= rightArr[iRight])
                    arr[k++] = leftArr[iLeft++];
                else
                    arr[k++] = rightArr[iRight++];
            }

            // Copy remaining elements (if any)
            while (iLeft < leftSize)
                arr[k++] = leftArr[iLeft++];
            while (iRight < rightSize)
                arr[k++] = rightArr[iRight++];
        }

        public void Display(double[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }

        
    }
}
