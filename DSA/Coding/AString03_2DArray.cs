using System;

namespace Coding_AString03
{
    class AString03_2DArray
    {
        // "static void main" must be defined in a public class.
        private static void PrintArray(int[][] a)
        {
            for (int i = 0; i < a.Length; ++i)
            {
                Console.WriteLine(a[i]);
            }
            for (int i = 0; i < a.Length; ++i)
            {
                for (int j = 0; a[i] != null && j < a[i].Length; ++j)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main02()
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
        }
    }
}
