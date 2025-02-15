namespace CountSort {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students:");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] ages = new int[num];

            Console.WriteLine($"Enter {num} student ages (between 10 and 18):");
            for (int i = 0; i < num; i++)
            {
                ages[i] = Convert.ToInt32(Console.ReadLine());

                // Validate input range
                if (ages[i] < 10 || ages[i] > 18)
                {
                    Console.WriteLine("Invalid age! Please enter ages between 10 and 18.");
                    i--;  // Ask for input again
                }
            }

            Console.WriteLine("\nUnsorted Student Ages:");
            Console.WriteLine(string.Join(" ", ages));

            // Perform Counting Sort
            CountingSort.CountSort(ages, 10, 18);

            Console.WriteLine("\nSorted Student Ages:");
            Console.WriteLine(string.Join(" ", ages));
        }
    }
}