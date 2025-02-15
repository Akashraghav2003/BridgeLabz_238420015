using MergeSort;

namespace mergeSort
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of  book ");
            int books = Convert.ToInt32(Console.ReadLine());

            double[] arr = new double[books];


            for (int i = 0; i < books; i++)
            {
                Console.WriteLine($"Enter the {i + 1}. Book price: ");
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }

            Merge merge = new Merge();
            merge.Display(arr);

            Merge.MergeSort(arr, 0, books-1);
            Console.WriteLine("Books price after merge sort: ");
            merge.Display(arr);


        }
    }
}