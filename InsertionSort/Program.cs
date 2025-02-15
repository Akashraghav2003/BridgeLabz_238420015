namespace InsertionSort
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Employee");
            int employee = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[employee];


            for (int i = 0; i < employee; i++)
            {
                Console.WriteLine($"Enter the {i + 1}. employee ID: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Insertion insertion = new Insertion();
            insertion.Display(arr);

            insertion.Sort(arr);
            Console.WriteLine("Employee ID afrter bubble sorting ");
            insertion.Display(arr);


        }
    }
}