using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateElement
{
    internal class RotateElementInList
    {
        public List <int> Rotate(List<int> list, int index)
        {
            List<int> result = new List<int>(); 
            
            for (int i = index;i< list.Count;i++)
            {
                result.Add(list[i]);
            }

            for(int i =0;i < index; i++)
            {
                result.Add(list[i]);
            }

            return result;
        }
    }
}
