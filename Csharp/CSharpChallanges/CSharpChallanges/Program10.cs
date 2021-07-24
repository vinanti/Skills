//Less Than 100?
/*Given two numbers, return true if the sum of both numbers is less than 100. Otherwise return false.

Examples
lessThan100(22, 15) ➞ true
// 22 + 15 = 37

lessThan100(83, 34) ➞ false
// 83 + 34 = 117

lessThan100(3, 77) ➞ true*/
using System;

namespace CSharpChallanges
{
    class Program10
    {
        static void Main10(string[] args)
        {
            Console.WriteLine(lessThan100(22,15));
            Console.WriteLine(lessThan100(83,34));
            Console.WriteLine(lessThan100(3,77));
        }
        public static bool lessThan100(int a, int b) => (a + b) < 100;
    }
}
