using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesWhilePreservingOrder
{
    internal class RemoveDuplicates
    {
        public void Remove(List<int> list)
        {
            HashSet<int> set = new HashSet<int>();
            int index = 0;

            for(int i = 0; i < list.Count; i++)
            {
                if (set.Contains(list[i]))
                {
                   list[index] = list[i];
                    index++;
                }
                else
                {
                    set.Add(list[i]);
                }
            }
            while(set.Count < list.Count)
            {
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
