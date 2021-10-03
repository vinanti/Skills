using System;
using System.Collections.Generic;

namespace Coding_Q0073
{
    class Q0073
    {
        static void Main73()
        {
            SetZeroes(new int[][] { new int[] { 1, 2, 3, 4 }, new int[] { 5, 0, 7, 8 }, new int[] { 0, 10, 11, 12 }, new int[] { 13, 14, 15, 0 } });
        }
        public static void SetZeroes(int[][] matrix)
        {
            HashSet<int> rows = new HashSet<int>();
            HashSet<int> cols = new HashSet<int>();
            for (int i = 0; i < matrix.Length; i++)
                for (int j = 0; j < matrix[0].Length; j++)
                    if (matrix[i][j] == 0)
                    {
                        if (!rows.Contains(i)) rows.Add(i);
                        if (!cols.Contains(j)) cols.Add(j);
                    }
            for (int i = 0; i < matrix.Length; i++)
                for (int j = 0; j < matrix[0].Length; j++)
                    if (rows.Contains(i) || cols.Contains(j)) matrix[i][j] = 0;
        }
    }
}
