namespace SearchIn2DArray
{
	class Program
	{
        static void Main()
        {
            Console.WriteLine("Enter the number of rows:");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of columns:");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, cols];
            Console.WriteLine("Enter the matrix elements row-wise:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Enter the target value to search: ");
            int target = Convert.ToInt32(Console.ReadLine());

            (int row, int col) = MatrixSearch.SearchMatrix(matrix, target);

            if (row != -1)
                Console.WriteLine($"Target found at index: ({row}, {col})");
            else
                Console.WriteLine("Target not found in the matrix.");
        }
    }
}