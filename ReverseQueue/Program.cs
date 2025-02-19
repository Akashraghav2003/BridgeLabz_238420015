using System;
using System.Collections;

namespace ReverseQueue
{
	class MyClass
	{
        static void Main(string[] args)
        {
            ReverseingTheQueue reverseingTheQueue = new ReverseingTheQueue();
            Console.WriteLine("Enetr the element of queue: ");
            Queue input = new Queue(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));

            reverseingTheQueue.Reverse(input);

            Console.Write("Queue after reversing: ");
            foreach(var item in input) Console.Write(item+" ");



        }
    }
}