/*2D Array
 https://leetcode.com/explore/learn/card/array-and-string/202/introduction-to-2d-array/1166/
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_2DArray_ns
{

    public class String03_2DArray
    {
        static void Main03()
        {
            Console.WriteLine("Example I:");
            int[,] a = new int[2, 5];
            printArray(a);
            Console.WriteLine("Example II:");
            int[,] b = new int[2,0];
            printArray(b);
            //Jagged Array
            Console.WriteLine("Example III:");
            int[][] c = new int[2][];
            c[0] = new int[3];
            c[1] = new int[5];
        }
        private static void printArray(int[,] a)
        {
            foreach(int i in a)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            Console.WriteLine("--------");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i,j]);
                }
                Console.WriteLine();
            }
        }

    }
}
