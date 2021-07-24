using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqChallenges
{
    class Program1
    {
        static void Main1(string[] args)
        {
            /*Numbers from range
Given an array of integers, write a query that returns list of numbers greater than 30 and less than 100.
Expected input and output
[67, 92, 153, 15] → 67, 92*/
            
            int[] array = { 67, 92, 153, 15 };

            var result = array.Where(x => x > 30 && x < 100).ToArray();

            foreach(int item in result)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
