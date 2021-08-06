/*Evenly spaced
 * https://codingbat.com/prob/p198700
Given three ints, a b c, one of them is small, one is medium and one is large. 
Return true if the three values are evenly spaced, so the difference between small and medium is the same as the difference between medium and large.

evenlySpaced(2, 4, 6) → true
evenlySpaced(4, 6, 2) → true
evenlySpaced(4, 6, 3) → false 

Q:
-Ve values - yes

T:
evenlySpaced(0, 0, 0) -> true
evenlySpaced(2, 4, 6) → true
evenlySpaced(4, 6, 2) → true
 4>6? 6-4 = 2
6>2
evenlySpaced(4, 6, 3) → false 

A:
(a, b, c)
abs(a, b) == abs(b, c) 
 */

using System;
using System.Collections.Generic;
using System.Linq;
namespace Q001
{
    class Program001
    {
        static void Main001(string[] args)
        {
            Console.WriteLine(evenlySpaced(0, 0, 0));
            Console.WriteLine(evenlySpaced(2, 4, 6));
            Console.WriteLine(evenlySpaced(4, 6, 2));
            Console.WriteLine(evenlySpaced(4, 6, 3));
        }

        public static bool evenlySpaced(int a, int b, int c)
        {
            List<int> sort = new List<int> { a, b, c };
            sort = sort.OrderBy(x => x).ToList();
            a = sort[0]; b = sort[1]; c = sort[2];
            return (a > b ? Math.Abs(a - b) : Math.Abs(b - a)) == (b > c ? Math.Abs(b - c) : Math.Abs(c - b));
        }
    }
}