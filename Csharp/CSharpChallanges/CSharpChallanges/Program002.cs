//Return the Sum of Two Numbers
/*Create a function that takes two numbers as arguments and return their sum.

Examples
Sum(3, 2) ➞ 5

Sum(-3, -6) ➞ -9

Sum(7, 3) ➞ 10*/
using System;

namespace CSharpChallanges
{
    class Program002
    {
        static void Main2(string[] args)
        {
            Console.WriteLine(Sum(2, 3));
            Console.WriteLine(Sum(-3, -6));
            Console.WriteLine(Sum(7, 3));
        }
        public static int Sum(int a, int b) => a + b;
    }
}
