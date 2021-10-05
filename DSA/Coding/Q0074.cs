using System;

namespace Coding
{
    class Q0074
    {
        static void Main5()
        {
            SearchMatrix(new int[][] { new int[] { 1, 3, 5, 7 }, new int[] { 10, 11, 16, 20 }, new int[] { 23, 30, 34, 60 } }, 3);
        }
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int row = -1;
            if (matrix.Length == 1) row = 0;
            {
                for (int i = 0; i < matrix.Length - 1; i++)
                {
                    if (matrix[i][0] == target) return true;
                    if (matrix[i + 1][0] == target) return true;
                    if (matrix[i][0] <= target && matrix[i + 1][0] >= target) row = i;
                }
                if (row == -1) row = matrix.Length - 1;
            }
            
            for (int i = 0; i < matrix[0].Length; i++)
                if (matrix[row][i] == target) return true;
            return false;
        }
    }
}
