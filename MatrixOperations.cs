   // Write a program to perform matrix manipulation operations 
   // like addition, subtraction, multiplication, and transpose. 
   // Also finding the determinant and inverse of a matrix. 
   // The program should take random matrices as input and 
   // display the result of the operations.


using System;

namespace Assignment4 {
    public class MatrixOperations {
        // Method to create a random matrix
        public static double[,] CreateMatrix(int rows, int cols) {
            Random random = new Random();
            double[,] matrix = new double[rows, cols];

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    matrix[i, j] = random.Next(1, 10); // Random values between 1 and 9
                }
            }

            return matrix;
        }

        // Method to add two matrices
        public static double[,] AddMatrices(double[,] mat1, double[,] mat2) {
            int rows = mat1.GetLength(0);
            int cols = mat1.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    result[i, j] = mat1[i, j] + mat2[i, j];
                }
            }

            return result;
        }

        // Method to subtract two matrices
        public static double[,] SubtractMatrices(double[,] mat1, double[,] mat2) {
            int rows = mat1.GetLength(0);
            int cols = mat1.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    result[i, j] = mat1[i, j] - mat2[i, j];
                }
            }

            return result;
        }

        // Method to multiply two matrices
        public static double[,] MultiplyMatrices(double[,] mat1, double[,] mat2) {
            int rows = mat1.GetLength(0);
            int cols = mat2.GetLength(1);
            int common = mat1.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    for (int k = 0; k < common; k++) {
                        result[i, j] += mat1[i, k] * mat2[k, j];
                    }
                }
            }

            return result;
        }

        // Method to find the transpose of a matrix
        public static double[,] TransposeMatrix(double[,] matrix) {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            double[,] transpose = new double[cols, rows];

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    transpose[j, i] = matrix[i, j];
                }
            }

            return transpose;
        }

        // Method to find the determinant of a 2x2 matrix
        public static double Determinant2x2(double[,] matrix) {
            double det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
			return det;
			return det;
        }

        // Method to find the determinant of a 3x3 matrix
        public static double Determinant3x3(double[,] matrix) {
            double det = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
                 - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
                 + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
				 
				return det;
        }

        // Method to find the inverse of a 2x2 matrix
        public static double[,] Inverse2x2(double[,] matrix) {
            double det = Determinant2x2(matrix);
            if (det == 0) {
                Console.WriteLine("Matrix is not invertible.");
                return null;
            }

            double[,] inverse = new double[2, 2];
            inverse[0, 0] = matrix[1, 1] / det;
            inverse[0, 1] = -matrix[0, 1] / det;
            inverse[1, 0] = -matrix[1, 0] / det;
            inverse[1, 1] = matrix[0, 0] / det;

            return inverse;
        }

        // Method to display a matrix
        public static void DisplayMatrix(double[,] matrix) {
            if (matrix == null) {
                Console.WriteLine("Matrix is null.");
                return;
            }

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Main method
        public static void Main() {
            double[,] matrix1 = CreateMatrix(3, 3);

            Console.WriteLine("Matrix 1:");
            DisplayMatrix(matrix1);

            Console.WriteLine("Determinant of Matrix 1 (3x3): " + Determinant3x3(matrix1));

            double[,] matrix2x2 = CreateMatrix(2, 2);
            Console.WriteLine("Matrix 2x2:");
            DisplayMatrix(matrix2x2);

            double determinant2x2 = Determinant2x2(matrix2x2);
            Console.WriteLine("Determinant of Matrix 2x2: " + determinant2x2);

            if (determinant2x2 != 0) {
                Console.WriteLine("Inverse of Matrix 2x2:");
                DisplayMatrix(Inverse2x2(matrix2x2));
            } else {
                Console.WriteLine("Matrix 2x2 is not invertible.");
            }
        }
    }
}



 