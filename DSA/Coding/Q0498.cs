using System;
using System.Collections;

namespace Coding_Q0498
{
    class Q0498
    {
        static void Main498()
        {
            int[][] mat = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
            FindDiagonalOrder(mat);
        }
        public static int[] FindDiagonalOrder(int[][] matrix)
        {

            // Check for empty matrices
            if (matrix == null || matrix.Length == 0)
            {
                return new int[0];
            }

            // Variables to track the size of the matrix
            int N = matrix.Length;
            int M = matrix[0].Length;

            // The two arrays as explained in the algorithm
            int[] result = new int[N * M];
            int k = 0;
            ArrayList intermediate = new ArrayList();

            // We have to go over all the elements in the first
            // row and the last column to cover all possible diagonals
            for (int d = 0; d < N + M - 1; d++)
            {

                // Clear the intermediate array every time we start
                // to process another diagonal
                intermediate.Clear();

                // We need to figure out the "head" of this diagonal
                // The elements in the first row and the last column
                // are the respective heads.
                int r = d < M ? 0 : d - M + 1;
                int c = d < M ? d : M - 1;

                // Iterate until one of the indices goes out of scope
                // Take note of the index math to go down the diagonal
                while (r < N && c > -1)
                {

                    intermediate.Add(matrix[r][c]);
                    ++r;
                    --c;
                }

                // Reverse even numbered diagonals. The
                // article says we have to reverse odd 
                // numbered articles but here, the numbering
                // is starting from 0 :P
                if (d % 2 == 0)
                {
                    intermediate.Reverse();
                }

                for (int i = 0; i < intermediate.Count; i++)
                {
                    result[k++] = (int)intermediate[i];
                }
            }
            return result;
        }
    }
}
