namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of job applicants:");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.Write($"Enter the salary of applicant {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nUnsorted Salaries:");
            Heap heap = new Heap();
            heap.Display(arr);

            // Correct function call
            Heap.HeapSortAlgo(arr);

            Console.WriteLine("\nSalaries after Heap Sorting:");
            heap.Display(arr);
        }
    }
}