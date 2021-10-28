﻿using System;
using System.Collections.Generic;

namespace Coding_Q0054
{
    class Q0054
    {
        static void Main54()
        {
            SpiralOrder(new int[][] { 
                new int[] { 1, 2, 3, 4 }, 
                new int[] { 5, 6, 7, 8 }, 
                new int[] { 9, 10, 11, 12 } });
        }
        public static List<int> SpiralOrder(int[][] matrix)
        {
            List<int> result = new List<int>();
            int rows = matrix.Length;
            int columns = matrix[0].Length;
            int up = 0;
            int left = 0;
            int right = columns - 1;
            int down = rows - 1;

            while (result.Count < rows * columns)
            {
                // Traverse from left to right.
                for (int col = left; col <= right; col++)
                {
                    result.Add(matrix[up][col]);
                }
                // Traverse downwards.
                for (int row = up + 1; row <= down; row++)
                {
                    result.Add(matrix[row][right]);
                }
                // Make sure we are now on a different row.
                if (up != down)
                {
                    // Traverse from right to left.
                    for (int col = right - 1; col >= left; col--)
                    {
                        result.Add(matrix[down][col]);
                    }
                }
                // Make sure we are now on a different column.
                if (left != right)
                {
                    // Traverse upwards.
                    for (int row = down - 1; row > up; row--)
                    {
                        result.Add(matrix[row][left]);
                    }
                }
                left++;
                right--;
                up++;
                down--;
            }

            return result;
        }
    }
}
