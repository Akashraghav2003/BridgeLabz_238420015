using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchIn2DArray
{
    internal class MatrixSearch
    {
        public static (int, int) SearchMatrix(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int left = 0, right = rows * cols - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int row = mid / cols, col = mid % cols; // Convert 1D index to 2D indices
                int midValue = matrix[row, col];

                if (midValue == target)
                    return (row, col); // Return row and column index if target is found
                else if (midValue < target)
                    left = mid + 1; // Search in the right half
                else
                    right = mid - 1; // Search in the left half
            }

            return (-1, -1); // Return (-1, -1) if target is not found
        }
    }
}
