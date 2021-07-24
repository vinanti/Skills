using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqChallenges
{
    class Program6
    {
        static void Main6(string[] args)
        {
            /*Replace substring
Write a query that replaces 'ea' substring with astersik (*) in given list of words.
Expected input and output
"learn", "current", "deal" →  "l*rn", "current", "d*l"*/

            var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };

            var result = words.Select(w => w.Replace("ea", "*")).ToList();

            foreach (string item in result)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
