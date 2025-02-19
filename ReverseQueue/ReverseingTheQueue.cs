using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseQueue
{
    internal class ReverseingTheQueue
    {
        public void Reverse(Queue queue)
        {
            Stack  stack = new Stack();
            while (queue.Count > 0)
            {
                var temp = queue.Dequeue();
                stack.Push(temp);
            }
            while (stack.Count > 0)
            {
                var temp  = stack.Pop();
                queue.Enqueue(temp);
            }
        }
    }
}
