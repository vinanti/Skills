using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqChallenges
{
    class Program8
    {
        static void Main8(string[] args)
        {
            /*Shuffle an array
Write a query that shuffles sorted array.
Expected input and output
[1, 2, 3, 4, 5, 6, 7, 8, 9, 10] → [4, 9, 3, 5, 2, 10, 1, 6, 8, 7]
[38, 24, 8, 0, -1, -17, -33, -100] → [0, -100, -17, 38, 8, -1, 24, -33,]*/

            var array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var r = new Random();
            var result = array.OrderBy(i => r.Next()).ToList();

            foreach (int item in result)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
