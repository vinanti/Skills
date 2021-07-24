using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqChallenges
{
    class Program4
    {
        static void Main4(string[] args)
        {
            /*Top 5 numbers
Write a query that returns top 5 numbers from the list of integers in descending order.
Expected input and output
[78, -9, 0, 23, 54,  21, 7, 86]  → 86 78 54 23 21*/

            List<int> numbers = new List<int> { 6, 0, 999, 11, 443, 6, 1, 24, 54 };

            var result = numbers.OrderByDescending(x => x).Take(5).ToList();

            foreach (int item in result)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
