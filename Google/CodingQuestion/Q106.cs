/* Implementation of two-dimensional array
 * Implemet menthod to print 2D array
Print below using 2-D array
Example I:
0 0 0 0 0 
0 0 0 0 0 
Example II:
null
null


Example III:
0 0 0 
0 0 0 0 0 
 */
using System;
namespace Q106ns
{
    class Q106
    {
        private static void printArray(int[,] a)
        {
            //for (int i = 0; i < a.Length; ++i)
            //{
            //    Console.WriteLine(a[i,0]);
            //}
            for (int i = 0; i < a.GetLength(0); ++i)
            {
                for (int j = 0; j < a.GetLength(1); ++j)
                {
                    Console.Write(a[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("Example I:");
            int[,] a = new int[2,5];
            printArray(a);
            Console.WriteLine("Example II:");
            int[,] b = new int[2,0];
            printArray(b);
            Console.WriteLine("Example III:");
            //b[0] = new int[3];
            //b[1] = new int[5];
            printArray(b);
        }
    }
}
 