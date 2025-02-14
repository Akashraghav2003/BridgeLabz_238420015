using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingWindow
{
    internal class Node
    {
        public int Data { get; set; }
        public Node Next;
        public Node Prev;

        public Node(int data)
        {
            Data = data;
            Prev = null;
            Next = null;
        }
    }
}
