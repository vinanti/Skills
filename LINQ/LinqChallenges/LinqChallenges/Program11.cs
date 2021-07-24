using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqChallenges
{
    class Program11
    {
        static void Main11(string[] args)
        {
            /*Unique values
Given a non-empty list of strings, return a list that contains only unique (non-duplicate) strings.
Expected input and output
["abc", "xyz", "klm", "xyz", "abc", "abc", "rst"] → ["klm", "rst"]*/

            var values = new List<string> { "Hi", "Meow", "Hello", "Meow", "Hi!", "Meow", "Hi", "Bye" };

            var result = new int[] { };
            foreach (int item in result)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
