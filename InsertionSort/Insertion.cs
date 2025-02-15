using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    internal class Insertion
    {
        public void Sort(int[] arr)
        {
            int len = arr.Length;

            for (int i = 0; i < len; i++)
            {
                int index = i;
                while (index > 0 && arr[index - 1] > arr[index])
                {
                    int temp = arr[index - 1];
                    arr[index-1] = arr[index];
                    arr[index] = temp;
                    index--;
                }
            }
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
