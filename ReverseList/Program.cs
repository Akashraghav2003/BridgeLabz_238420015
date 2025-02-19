using System.Collections;

namespace ReverseList
{
	class Program
	{
        static void Main(string[] args)
        {
            ReverseListAndLinkedList rev = new ReverseListAndLinkedList();  

            ArrayList list = new ArrayList();
            Console.WriteLine("Enter the element of arrayList:");
            string [] inputArray = Console.ReadLine().Split(' ');
            foreach (string input in inputArray)
            {
                if (int.TryParse(input, out int value))
                {
                    list.Add(value);
                }
            }

            rev.Reverse(list);
            Console.WriteLine("ArrayList after reverse: ");
            Console.WriteLine("Reverse ArrayList: "+ string.Join(",", list.ToArray()));

            LinkedList<int> ints = new LinkedList<int>();
            Console.WriteLine("Enter the element of LinkedList (with space ):");
            string[] linkedInput = Console.ReadLine().Split(' ');
            foreach (string s  in linkedInput)
            {
                if(int.TryParse(s, out int value))
                {
                    ints.AddLast(value);
                }
            }
            rev.ReverseLinkedList(ints);
            Console.WriteLine("Reversed LinkedList: ");
            foreach(var item in ints)
            {
                Console.Write(item+" ");
            }

        }
    }
}