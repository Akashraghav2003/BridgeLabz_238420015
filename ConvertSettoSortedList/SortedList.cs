using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSettoSortedList
{
    internal class SortedList
    {
        public List<int> Sorted(HashSet<int> set)
        {
            if (set == null) Console.WriteLine("set is null");

            List<int> list = new List<int>(set);

            MergeSort(list, 0, list.Count - 1);
            return list;
        }
        public void MergeSort(List<int> list, int start, int end)
        {
            if(start >= end) return;

            int mid  =start+ (end - start)/2;

            MergeSort(list, start, mid);
            MergeSort(list, mid+1,end);

            Merge(list, start, mid,  end);
        }

        public void Merge(List<int> list, int start, int mid, int end)
        {
            List<int> result = new List<int>();

            int i = start, j = mid + 1;

            while (i <= mid && j <= end)
            {
                if (list[i] < list[j])
                {
                    result.Add(list[i++]);
                }
                else
                {
                    result.Add(list[j++]);
                }
            }
            while (i <= mid)
            {
                result.Add(list[i++]);
            }
            while (j <= end)
            {
                result.Add(list[j++]);
            }

            for (i = 0; i < result.Count; i++)
            {
                list[start+i] = result[i];
            }
        }
    }
}
