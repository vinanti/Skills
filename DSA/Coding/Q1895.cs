using System;
using System.Collections.Generic;

namespace Coding
{
    class Q1895
    {
        static void Main1895()
        {
            LargestMagicSquare(new int[][] {
                new int[] { 5, 1, 3, 1 },
                new int[] { 9, 3, 3, 1 },
                new int[] { 1, 3, 3, 8 }});
        }
        public static int LargestMagicSquare(int[][] grid)
        {
            int length = grid.Length < grid[0].Length ? grid.Length : grid[0].Length;
            int row = 0, col = 0;
            while (length > 1)
            {
                int[][] temp = new int[length][];
                for (int i = row; i < grid.Length; i++)
                {
                    if (i - row < length)
                    {
                        temp[i - row] = new int[length];
                        for (int j = col; j < grid[0].Length; j++)
                        {
                            if (i - row < length && j - col < length)
                                temp[i - row][j - col] = grid[i][j];
                        }
                    }
                }
                if (IsMagicSquare(temp)) return length;
                if (row + length < grid.Length && col + length == grid[0].Length) { row++; col = 0; } 
                else if (col + length < grid[0].Length) col++;
                else
                {
                    row = 0; col = 0;
                    length--;
                }
            }
            return length;
        }
        public static bool IsMagicSquare(int[][] grid)
        {
            int mainSum = 0, sum = 0, length = grid.Length;
            //diagonal
            for (int i = 0; i < length; i++)
            {
                mainSum += grid[i][i];
                sum += grid[i][length - 1 - i];
            }
            if (mainSum != sum) return false;
            //row
            for (int i = 0; i < length; i++)
            {
                sum = 0;
                for (int j = 0; j < length; j++)
                {
                    sum += grid[i][j];
                }
                if (mainSum != sum) return false;
            }

            //col
            for (int i = 0; i < length; i++)
            {
                sum = 0;
                for (int j = 0; j < length; j++)
                {
                    sum += grid[j][i];
                }
                if (mainSum != sum) return false;
            }
            return true;
        }
    }
}
