using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricDifference
{
    internal class SymmetricDifferenceOfSet
    {
        public HashSet<int> DifferenceOfSet(HashSet<int> set1, HashSet<int> set2)
        {
            foreach (var item in set1)
            {
                if(! set2.Contains(item))
                {
                    set2.Add(item);
                }
            }
            return set2;
        }
    }
}
