using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSubsets
{
    internal class SubsetFinder
    {
        public bool CheckSubset(HashSet<int> set1, HashSet<int> set2)
        {
            if(set1.Count < set2.Count) return false;

            bool flag = true;
            foreach(int i in set2)
            {
                if (!set1.Contains(i)) 
                { 
                    flag = false; 
                    break;
                }
            }
            return flag;
        }
    }
}
