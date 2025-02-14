using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingStack
{
    internal class Stack
    {
        public Node top;

        public Stack()
        {
            top = null;
        }

        public void push(int item)
        {
            Node newItem = new Node(item);
            newItem.Next = top;
            top = newItem;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public int pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return  -1;
            }
            int value = top.Data;
            top = top.Next;
            return value;
        }

        
        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            return top.Data;
        }
        
    }
}
