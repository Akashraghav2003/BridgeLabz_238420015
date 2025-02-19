namespace SymmetricDifference
{
	class Program
	{
        static void Main(string[] args)
        {
            SymmetricDifferenceOfSet symmetricDifferenceOfSet = new SymmetricDifferenceOfSet();     
            Console.WriteLine("Enter the element of set1: ");
            HashSet<int> set1 = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));

            Console.WriteLine("Enter the element of set2: ");
            HashSet<int> set2 = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));

            HashSet<int> result = symmetricDifferenceOfSet.DifferenceOfSet(set1, set2);
            Console.Write("Symmetric Difference of Set1 And Set2 ");
            foreach (int x in result) Console.Write(x+ " ");
        }
    }
}