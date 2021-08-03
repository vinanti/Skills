//Return the Remainder from Two Numbers
/*There is a single operator in C#, capable of providing the remainder of a division operation. Two numbers are passed as parameters. The first parameter divided by the second parameter will have a remainder, possibly zero. Return that value.

Examples
Remainder(1, 3) ➞ 1

Remainder(3, 4) ➞ 3

Remainder(-9, 45) ➞ -9

Remainder(5, 5) ➞ 0*/
using System;

namespace CSharpChallanges
{
    class Program008
    {
        static void Main8(string[] args)
        {
            Console.WriteLine(Remainder(1,3));
            Console.WriteLine(Remainder(3,4));
            Console.WriteLine(Remainder(-9,45));
            Console.WriteLine(Remainder(5,5));
        }
        public static int Remainder(int x, int y) => x % y;
    }
}
