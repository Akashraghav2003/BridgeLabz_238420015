using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionIntersectionOfTwoSets
{
    internal class UnionAndIntersection
    {
        public HashSet<int> Union(HashSet<int> set1, HashSet<int> set2)
        { 

            foreach (int i in set1)
            {
                if (!set2.Contains(i))
                {
                    set2.Add(i);
                }
            }

            return set2;
        }

        public HashSet<int> InterSection(HashSet<int> set1, HashSet<int> set2)
        {
            HashSet<int> result = new HashSet<int>();
            foreach (int i in set1)
            {
                if (set2.Contains(i))
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
