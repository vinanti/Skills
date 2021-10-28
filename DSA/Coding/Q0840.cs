using System;
using System.Collections.Generic;

namespace Coding
{
    class Q0840
    {
        static void Main01()
        {
            NumMagicSquaresInside(new int[][] { new int[] { 7, 0, 5 }, new int[] { 2, 4, 6 }, new int[] { 3, 8, 1 } });
        }
        public static int NumMagicSquaresInside(int[][] grid)
        {
            bool magicSquare = true; int count = 0;
            for (int i = 0; i < grid.Length - 2; i++)
                for (int j = 0; j < grid[0].Length - 2; j++)
                {
                    bool isDistinct = true;
                    HashSet<int> hashSet = new HashSet<int>();
                    if (grid[i][j] > 0 && grid[i][j] < 10 && !hashSet.Contains(grid[i][j]) && isDistinct) hashSet.Add(grid[i][j]); else isDistinct = false;
                    if (grid[i][j+1] > 0 && grid[i][j + 1] < 10 && !hashSet.Contains(grid[i][j + 1]) && isDistinct) hashSet.Add(grid[i][j + 1]); else isDistinct = false;
                    if (grid[i][j+2] > 0 && grid[i][j + 2] < 10 && !hashSet.Contains(grid[i][j + 2]) && isDistinct) hashSet.Add(grid[i][j + 2]); else isDistinct = false;
                    if (grid[i+1][j] > 0 && grid[i + 1][j] < 10 && !hashSet.Contains(grid[i + 1][j]) && isDistinct) hashSet.Add(grid[i + 1][j]); else isDistinct = false;
                    if (grid[i+1][j+1] > 0 && grid[i + 1][j + 1] < 10 && !hashSet.Contains(grid[i + 1][j + 1]) && isDistinct) hashSet.Add(grid[i + 1][j + 1]); else isDistinct = false;
                    if (grid[i+1][j+2] > 0 && grid[i + 1][j + 2] < 10 && !hashSet.Contains(grid[i + 1][j + 2]) && isDistinct) hashSet.Add(grid[i + 1][j + 2]); else isDistinct = false;
                    if (grid[i+2][j] > 0 && grid[i + 2][j] < 10 && !hashSet.Contains(grid[i + 2][j]) && isDistinct) hashSet.Add(grid[i + 2][j]); else isDistinct = false;
                    if (grid[i+2][j+1] > 0 && grid[i + 2][j + 1] < 10 && !hashSet.Contains(grid[i + 2][j + 1]) && isDistinct) hashSet.Add(grid[i + 2][j + 1]); else isDistinct = false;
                    if (grid[i+2][j+2] > 0 && grid[i + 2][j + 2] < 10 && !hashSet.Contains(grid[i + 2][j + 2]) && isDistinct) hashSet.Add(grid[i + 2][j + 2]); else isDistinct = false;

                    if (isDistinct)
                    {
                        int sum = grid[i][j] + grid[i][j + 1] + grid[i][j + 2];
                        //rows
                        magicSquare = magicSquare && grid[i][j] + grid[i][j + 1] + grid[i][j + 2] == sum;
                        magicSquare = magicSquare && grid[i + 1][j] + grid[i + 1][j + 1] + grid[i + 1][j + 2] == sum;
                        magicSquare = magicSquare && grid[i + 2][j] + grid[i + 2][j + 1] + grid[i + 2][j + 2] == sum;
                        //Cols
                        magicSquare = magicSquare && grid[i][j] + grid[i + 1][j] + grid[i + 2][j] == sum;
                        magicSquare = magicSquare && grid[i][j + 1] + grid[i + 1][j + 1] + grid[i + 2][j + 1] == sum;
                        magicSquare = magicSquare && grid[i][j + 2] + grid[i + 1][j + 2] + grid[i + 2][j + 2] == sum;
                        //diagonal
                        magicSquare = magicSquare && grid[i][j] + grid[i + 1][j + 1] + grid[i + 2][j + 2] == sum;
                        magicSquare = magicSquare && grid[i][j + 2] + grid[i + 1][j + 1] + grid[i + 2][j] == sum;

                        if (magicSquare) count++;
                        else magicSquare = true;
                    }
                }
            return count;
        }
    }
}
