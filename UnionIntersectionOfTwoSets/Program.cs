namespace UnionIntersectionOfTwoSets
{
	class Program
	{
        static void Main(string[] args)
        {
            UnionAndIntersection unionAndIntersection = new UnionAndIntersection(); 
            Console.WriteLine("Enter the element of set1: ");
            HashSet<int> set1 = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));

            Console.WriteLine("Enter the element of set2: ");
            HashSet<int> set2 = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));

            HashSet<int> result1 = unionAndIntersection.Union(set1, set2);
            Console.Write("Union: ");
            foreach(int x in result1) Console.Write( x + " ");
            Console.WriteLine();
            Console.WriteLine("Enter the element of set1: ");
            HashSet<int> setI1 = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));

            Console.WriteLine("Enter the element of set2: ");
            HashSet<int> setI2 = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
            Console.Write("Intersection: ");
            HashSet <int> result2  = unionAndIntersection.InterSection(setI1, setI2);

            foreach (int x in result2) Console.Write( x + " ");
        }
    }
}