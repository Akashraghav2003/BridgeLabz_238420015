namespace ConvertSettoSortedList
{
	class Program
	{
        static void Main(string[] args)
        {
            SortedList list = new SortedList(); 
            Console.WriteLine("Enter the element of set1: ");
            HashSet<int> set1 = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));

            List<int> result = list.Sorted(set1);
            Console.WriteLine("Sorted list: ");
            foreach (int item in result) Console.Write(item +" ");
        }
    }
}