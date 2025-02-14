using System;

namespace SlidingWindow
{
    internal class Dque
    {
        private Node front;
        private Node rear;

        public Dque()
        {
            front = null;
            rear = null;
        }

        public void AddFront(int data)
        {
            Node newNode = new Node(data);
            if (front == null)
            {
                front = newNode;
                rear = newNode;
                return;
            }
            newNode.Next = front;
            front.Prev = newNode;
            front = newNode;
        }

        public void AddRear(int data)
        {
            Node newNode = new Node(data);
            if (front == null)
            {
                front = newNode;
                rear = newNode;
                return;
            }
            newNode.Prev = rear;
            rear.Next = newNode;
            rear = newNode;
        }

        public int RemoveFront()
        {
            if (front == null)
            {
                Console.WriteLine("Deque is empty");
                return -1;
            }
            int data = front.Data;
            front = front.Next;

            if (front == null) rear = null;
            else front.Prev = null;

            return data;
        }

        public int RemoveBack()
        {
            if (rear == null)
            {
                Console.WriteLine("Deque is empty");
                return -1;
            }
            int data = rear.Data;
            rear = rear.Prev;

            if (rear == null) front = null;
            else rear.Next = null;

            return data;
        }

        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Deque is empty");
                return;
            }

            Console.Write("Deque: ");
            Node temp = front;
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        public bool IsEmpty()
        {
            return front == null && rear == null;
        }

        public int GetFront()
        {
            if (IsEmpty()) throw new InvalidOperationException("Deque is empty");
            return front.Data;
        }

        public int GetRear()
        {
            if (IsEmpty()) throw new InvalidOperationException("Deque is empty");
            return rear.Data;
        }
    }
}
