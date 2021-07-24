//Return the Next Number from the Integer Passed
/*Create a function that takes a number as an argument, increments the number by +1 and returns the result.

Examples
Addition(0) ➞ 1

Addition(9) ➞ 10

Addition(-3) ➞ -2*/
using System;

namespace CSharpChallanges
{
    class Program4
    {
        static void Main4(string[] args)
        {
            Console.WriteLine(Addition(0));
            Console.WriteLine(Addition(9));
            Console.WriteLine(Addition(-3));
        }
        public static int Addition(int num) => ++num;
    }
}
