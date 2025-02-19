using System.Collections.Generic;

namespace FindTheNthElementFromTheEnd
{
	class Program
	{
        static void Main(string[] args)
        {
            NthElementFromEnd nthElementFromEnd = new NthElementFromEnd();
            LinkedList<string> list = new LinkedList<string>();

            Console.WriteLine("Enter elements of LinkedList (space-separated):");
            string[] input = Console.ReadLine().Split();
            foreach (var item in input)
            {
                list.AddLast(item);
            }
            Console.Write("Enter the index to return from last: ");
            int index = Convert.ToInt32(Console.ReadLine());

            string result = nthElementFromEnd.ElementFromEnd(list, index);
            Console.WriteLine(result);
        }
    }
}