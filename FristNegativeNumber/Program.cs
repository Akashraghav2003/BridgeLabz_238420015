namespace FristNegativeNumber
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];  

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter the {i} element: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            FristNegative fristNegative = new FristNegative();  
            

            Console.WriteLine("Frist negative element of array :"+ fristNegative.Negative(arr));
        }
    }
}