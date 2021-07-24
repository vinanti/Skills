using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqChallenges
{
    class Program5
    {
        static void Main5(string[] args)
        {
            /*Square greater than 20
Write a query that returns list of numbers and their squares only if square is greater than 20
Expected input and output
[7, 2, 30] → 7 - 49, 30 - 900*/

            List<int> Numbers = new List<int> { 3, 9, 2, 4, 6, 5, 7 };

            var result = Numbers.Where(n => n * n > 20).ToList();

            foreach (int item in result)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
