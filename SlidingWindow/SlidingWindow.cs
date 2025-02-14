using System;

namespace SlidingWindow
{
    internal class SlidingWindow
    {
        public void Max(int[] arr, int k)
        {
            if (k <= 0)
            {
                Console.WriteLine("Enter the window size greater than zero");
                return;
            }

            Dque dque = new Dque();

            for (int i = 0; i < arr.Length; i++)
            {
                while (!dque.IsEmpty() && dque.GetFront() < (i - k + 1))
                {
                    dque.RemoveFront();
                }

                while (!dque.IsEmpty() && arr[dque.GetRear()] < arr[i])
                {
                    dque.RemoveBack();
                }

                dque.AddRear(i);

                if (i >= k - 1)
                {
                    Console.Write(arr[dque.GetFront()] + " ");
                }
            }
        }
    }
}
