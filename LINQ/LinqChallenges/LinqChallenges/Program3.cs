using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqChallenges
{
    class Program3
    {
        static void Main3(string[] args)
        {
            /*Select words
Write a query that returns words starting with letter 'a' and ending with letter 'm'.
Expected input and output
"mum", "amsterdam", "bloom" → "amsterdam"*/

            List<string> words = new List<string> { "alabam", "am", "balalam", "tara", "", "a", "axeliam", "39yo0m", "trol" };

            var result = words.Where(x => x.StartsWith('a') && x.EndsWith('m')).ToList();

            foreach (string item in result)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
