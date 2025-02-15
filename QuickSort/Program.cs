namespace QuickSort
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Product");
            int product = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[product];


            for (int i = 0; i < product; i++)
            {
                Console.WriteLine($"Enter the {i + 1}. product price : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            QuickSortExample quick = new QuickSortExample();
            quick.Display(arr);

            QuickSortExample.QuickSort(arr, 0, product-1);
            Console.WriteLine("Product price after Quick Sort: ");
            quick.Display(arr);


        }
    }
}