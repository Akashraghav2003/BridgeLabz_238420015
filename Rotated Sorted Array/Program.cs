namespace Rotated_Sorted_Array
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter the rotated sorted array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter the {i} element: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            RotationPointFinder rotationPointFinder = new RotationPointFinder();    
            int rotationIndex = rotationPointFinder.FindRotationPoint(arr);
            Console.WriteLine("The rotation point (index of the smallest element) is: " + rotationIndex);
        }
    
    }
}