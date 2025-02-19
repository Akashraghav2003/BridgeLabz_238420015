using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseList
{
    internal class ReverseListAndLinkedList
    {
        public void Reverse(ArrayList list)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                object temp = list[left];
                list[left] = list[right];
                list[right] = temp;
                left++;
                right--;
            }
        }

        public void ReverseLinkedList(LinkedList<int> list)
        {
            if (list.Count <= 1) return;

            LinkedListNode<int> prev = null;
            LinkedListNode<int> current = list.First;

            while (current != null)
            {
                LinkedListNode<int> next = current.Next;
                current.List.Remove(current);
                list.AddFirst(current);
                current = next;
            }

        }
    }
}
