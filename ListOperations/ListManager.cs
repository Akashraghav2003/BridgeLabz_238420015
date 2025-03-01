using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOperations
{
    public class ListManager
    {
        
        public List<int> AddElements(List<int> list, int element)
        {
            list.Add(element);
            return list;
        }

        public bool RemoveElemnt(List<int> list, int element)
        {
            if(list == null)
                throw new ArgumentNullException(nameof(list), "List can not be null.");

            return list.Remove(element);
        }

        public int GetSize(List<int> list)
        {
            if (list == null) throw new ArgumentNullException(nameof(list), "List can not be empty");

            return list.Count;
        }
    
    }
}
