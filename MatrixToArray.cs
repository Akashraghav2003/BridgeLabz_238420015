// Working with Multi-Dimensional Arrays. Write a C# program to create a 2D Array and Copy the 2D Array into a single dimension array
// change these 2d array to 1D array in last


using System;

namespace ArrayLevel1
{
    class MatrixToArray
    {
        static void Main(string[] args)
        {
            int rows = 0, columns = 0;

            // Prompt user to input the number of rows and columns
            Console.WriteLine("Enter the number of rows: ");
            rows = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the number of columns: ");
            columns = int.Parse(Console.ReadLine());

            // Create a 2D array to store the matrix
            int[,] matrix = new int[rows, columns];

            // Take user input to populate the 2D matrix
            Console.WriteLine("Enter the elements of the matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine("Enter element at [" + i + "," + j + "]:");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Create a 1D array to store the matrix elements
            int[] array = new int[rows * columns];

            // Initialize an index variable to track the position in the 1D array
            int index = 0;

            // Copy elements from the 2D matrix to the 1D array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[index] = matrix[i, j]; // Store each matrix element in the 1D array
                    index++;
                }
            }

            // Display the elements of the 1D array
            Console.WriteLine("The elements in the 1D array are:");
            foreach (int value in array)
            {
                Console.Write(value + " "); // Output each element of the 1D array
            }
        }
    }
}
