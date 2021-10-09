using System;

namespace Coding_AString03
{
    class Usage_Matrix
    {
        
        private static void PrintArray(int[][] a)
        {
            for (int i = 0; i < a.Length; ++i)
            {
                Console.WriteLine("Row: " + i);
            }
            for (int i = 0; i < a.Length; ++i)
            {
                for (int j = 0; a[i] != null && j < a[i].Length; ++j)
                {
                    Console.Write(i + "" + j + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main10()
        {
            Console.WriteLine("Example I:");
            int[][] a = new int[2][];
            a[0] = new int[5];
            a[1] = new int[5];
            PrintArray(a);
            Console.WriteLine("Example II:");
            int[][] b = new int[2][];
            PrintArray(b);
            Console.WriteLine("Example III:");
            b[0] = new int[3];
            b[1] = new int[5];
            PrintArray(b);
                
            bool equal = a.Equals(b);
            int[] arr = new int[50];

            int[][] matrix = new int[2][];
            matrix[0] = new int[2];
            matrix[1] = new int[2];
            int k = 1;
            for (int i = 0; i < matrix.Length; i++)
                for (int j = 0; j < matrix[0].Length; j++)
                { matrix[i][j] = k; k++; }
            matrix[0][0] = 10;
   
            
        }
    }
}
