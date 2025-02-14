using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStackUsingRecursion
{
    internal class Stack
    {
        private Node top;

        public Stack()
        {
            top = null;
        }

        public void Push(int item)
        {
            Node newItem = new Node(item);

            newItem.Next = top;
            top = newItem;

            Console.WriteLine($"{item} is push");  
        }

        public int Pop()
        {
            if( top == null )
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            int value = top.Data;
            top = top.Next;
            Console.WriteLine($"{value} is poped");
            return value;
        }

        public int Peek()
        {
            if( top == null)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }

            return top.Data;
        }

        public bool isEmpty()
        {
            return top == null;
        }

        public void Sort()
        {
            if (!isEmpty())
            {
                int temp = Pop();
                Sort();
                SortedInserted(temp);
            }
            
        }

        public void SortedInserted(int temp)
        {
            if(isEmpty() || Peek() <= temp){
                Push(temp);
            }else
            {
                int item = Pop();
                SortedInserted(temp);
                Push(item);
            }
        }
        public void Display()
        {
            Node Current = top;
            while( Current != null )
            {
                Console.WriteLine(Current.Data+" ");
                Current = Current.Next;
            }
        }
    }
}
