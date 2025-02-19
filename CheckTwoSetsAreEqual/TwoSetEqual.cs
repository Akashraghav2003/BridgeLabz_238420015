using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTwoSetsAreEqual
{
    internal class TwoSetEqual
    {
        public bool EqualSet(SortedSet<int> set1, SortedSet<int> set2)
        {

            if (set1.Count != set2.Count )return false;
            bool flag = true;
            foreach ( int i in set1)
            {
                if (! set2.Contains(i))
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
