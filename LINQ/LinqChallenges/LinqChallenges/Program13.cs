using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqChallenges
{
    class Program13
    {
        static void Main13(string[] args)
        {
            /*Arrays dot product
Write a query that returns dot product of two arrays.
Expected input and output
[1, 2, 3], [4, 5, 6] → 32
[7, -9, 3, -5], [9, 1, 0, -4] → 74*/

            int[] array1 = new int[] { 5, 8, 2, 9 };
            int[] array2 = new int[] { 1, 7, 2, 4 };

            var result = new int[] { };
            foreach (int item in result)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
