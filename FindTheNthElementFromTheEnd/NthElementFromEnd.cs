using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FindTheNthElementFromTheEnd
{
    internal class NthElementFromEnd
    {
        public string ElementFromEnd(LinkedList<string> linkedList, int index)
        {
            LinkedListNode<string> slow = linkedList.First;
            LinkedListNode<string> fast = linkedList.First;

            for (int i = 0; i< index; i++)
            {
                if (fast == null) return null;

                fast = fast.Next;
                
            }

            while (fast != null)
            {
                fast = fast.Next;
                
                slow = slow.Next;
                

            }

            return slow.Value;

        }
    }
}
