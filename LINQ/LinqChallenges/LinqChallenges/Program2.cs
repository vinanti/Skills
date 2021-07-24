using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqChallenges
{
    class Program    
    {
        static void Main2(string[] args)
        {
            /*Minimum length
Write a query that returns words at least 5 characters long and make them uppercase.
Expected input and output
"computer", "usb" → "COMPUTER"*/
            
            List<string> animals = new List<string> { "zebra", "elephant", "cat", "dog", "rhino", "bat" };

            var result = animals.Where(x => x.Length >= 5).Select(x => x.ToUpper()).ToList();

            foreach (string item in result)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
