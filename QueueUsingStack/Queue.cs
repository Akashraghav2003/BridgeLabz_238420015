using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingStack
{
    internal class Queue
    {
        private Stack stackEnqueue;
        private Stack stackDequeue;

        public Queue()
        {
            stackEnqueue = new Stack();
            stackDequeue = new Stack();
        }
        public void Enqueue(int item)
        {
            stackEnqueue.push(item);
            Console.WriteLine($"{item} Enqueue successfull ");
        }
        public int  Dequeue()
        {
            if (stackDequeue.IsEmpty())
            {
                
                while(!stackEnqueue.IsEmpty())
                {
                    
                    stackDequeue.push(stackEnqueue.pop());
                }
            }
            
            if (stackDequeue.IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            
            return stackDequeue.pop();
        }
        public bool IsEmpty()
        {
            return stackEnqueue.IsEmpty() && stackDequeue.IsEmpty();
        }
    }
}
