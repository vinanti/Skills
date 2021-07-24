using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqChallenges
{
    class Program7
    {
        static void Main7(string[] args)
        {
            /*Last word containing letter
Given a non-empty list of words, sort it alphabetically and return a word that contains letter 'e'.
Expected input and output
["plane", "ferry", "car", "bike"]→ "plane"*/

            var words = new List<string> { "cow", "dog", "elephant", "cat", "rat", "squirrel", "snake", "stork" };

            var result = words.Where(w => w.EndsWith('e')).ToList();

            foreach (string item in result)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
