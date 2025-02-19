namespace FindSubsets
{
	class Program
	{
        static void Main(string[] args)
        {
            SubsetFinder finder = new SubsetFinder();
            Console.WriteLine("Enter the element of set: ");
            HashSet<int> set1 = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));

            Console.WriteLine("Enter the element of subSet: ");
            HashSet<int> set2 = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));

            bool result  = finder.CheckSubset(set1, set2);

            if (result) Console.WriteLine("set 2 is sub set of set1");
            else Console.WriteLine("set2 is not sub set of set1");
        }
    }
}