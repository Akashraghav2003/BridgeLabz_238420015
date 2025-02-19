namespace RemoveDuplicatesWhilePreservingOrder
{
	class Program
	{
        static void Main(string[] args)
        {
            RemoveDuplicates removeDuplicates = new RemoveDuplicates(); 
            Console.WriteLine("Enter the element of list with space: ");
            List<int> input = new List<int>(Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse));

            removeDuplicates.Remove(input);

            foreach (int i in input)
            {
                Console.Write(i + " ");
            }

        }
    }
}