using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestion
{
    class StringQ_004
    {
        static void Main004()
        {
            int[][] mat = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
            int[] result = FindDiagonalOrder(mat);
        }
        public static int[] FindDiagonalOrder(int[][] mat)
        {
            int m = mat.Length;
            int n = mat[0].Length;
            int[] result = new int[m * n];
            int x = 0, y = 0, j=1 ;
            bool flag = false;
            result[0] = mat[0][0];
            for (int i = 1; i < (m + n - 1); i++)
            {

                if (flag) x = i; else y = i;
                while (x +y <= i)
                {
                    if (x + y == i) { result[j] = mat[x][y]; j++; }
                    if (x > y) { x--; y++; }
                    else { x++; y--; }
                }

            }
            return result;
        }
    }
}
