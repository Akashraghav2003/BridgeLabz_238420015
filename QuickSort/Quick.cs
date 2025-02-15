using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
        class QuickSortExample
        {
            public static void QuickSort(int[] arr, int left, int right)
            {
                if (left < right)
                {
                    // Partition the array and get the pivot index
                    int pivotIndex = Partition(arr, left, right);

                    // Recursively sort the left and right parts
                    QuickSort(arr, left, pivotIndex - 1);
                    QuickSort(arr, pivotIndex + 1, right);
                }
            }

            public static int Partition(int[] arr, int left, int right)
            {
                int pivot = arr[right]; // Choosing the last element as pivot
                int i = left - 1; // Index for smaller elements

                for (int j = left; j < right; j++)
                {
                    if (arr[j] <= pivot)
                    {
                        i++;
                        Swap(arr, i, j);
                    }
                }

                // Swap pivot element to its correct position
                Swap(arr, i + 1, right);
                return i + 1;
            }
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
