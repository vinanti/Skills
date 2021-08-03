//Is the Number Less than or Equal to Zero?
/*Create a function that takes a number as its only argument and returns true if it's less than or equal to zero, otherwise return false.

Examples
lessThanOrEqualToZero(5) ➞ false

lessThanOrEqualToZero(0) ➞ true

lessThanOrEqualToZero(-2) ➞ true*/
using System;

namespace CSharpChallanges
{
    class Program009
    {
        static void Main9(string[] args)
        {
            Console.WriteLine(LessThanOrEqualToZero(5));
            Console.WriteLine(LessThanOrEqualToZero(0));
            Console.WriteLine(LessThanOrEqualToZero(-2));
        }
        public static bool LessThanOrEqualToZero(double a) => a <= 0;
    }
}
