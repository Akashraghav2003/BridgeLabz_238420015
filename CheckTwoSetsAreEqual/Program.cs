namespace CheckTwoSetsAreEqual
{
	class Program
	{
        static void Main(string[] args)
        {
            TwoSetEqual twoSetEqual = new TwoSetEqual();
            Console.WriteLine("Enter the element for set1 : ");
            SortedSet<int> set1 = new SortedSet<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));

            Console.WriteLine("Enter the element for set2: ");
            SortedSet<int> set2 = new SortedSet<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));

            bool result  = twoSetEqual.EqualSet(set1, set2);

            if (result) Console.WriteLine("Both set are equal");
            else Console.WriteLine("Sets are not equal.");

        }
    }
}