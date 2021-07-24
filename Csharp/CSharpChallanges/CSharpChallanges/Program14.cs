//Convert Hours into Seconds
/*Write a function that converts hours into seconds.

Examples
howManySeconds(2) ➞ 7200

howManySeconds(10) ➞ 36000

howManySeconds(24) ➞ 86400*/
using System;

namespace CSharpChallanges
{
    class Program14
    {
        static void Main14(string[] args)
        {
            Console.WriteLine(HowManySeconds(2));
            Console.WriteLine(HowManySeconds(10));
            Console.WriteLine(HowManySeconds(24));
        }
        public static int HowManySeconds(int hours) => hours * 60 * 60;

    }
}
