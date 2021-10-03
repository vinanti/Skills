using System;

namespace Coding
{
    class Q0240
    {
        static void Main240()
        {
            SearchMatrix(new int[][] { new int[] { 1, 3, 5, 7, 9 }, new int[] { 2, 4, 6, 8, 10 }, new int[] { 11, 13, 15, 17, 19 }, new int[] { 12, 14, 16, 18, 20 }, new int[] { 21, 22, 23, 24, 25 } }, 13);
        }
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int row = 0, col = 0;
            for (int i = 0; i < matrix.Length; i++)
                if (target >= matrix[i][0]) row = i;
            for (int i = 0; i < matrix[0].Length; i++)
                if (target >= matrix[0][i]) col = i;

            for (int i = 0; i <= row; i++)
                if (target == matrix[i][col]) return true;
            for (int i = 0; i <= col; i++)
                if (target == matrix[row][i]) return true;
            return false;
        }
    }
}
