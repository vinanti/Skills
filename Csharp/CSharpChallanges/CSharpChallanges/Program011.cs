//Are the Numbers Equal?
/*Create a function that takes two integers and checks if they are equal.

Examples
IsEqual(5, 6) ➞ false

IsEqual(1, 1) ➞ true

IsEqual(36, 35) ➞ false*/
using System;

namespace CSharpChallanges
{
    class Program011
    {
        static void Main11(string[] args)
        {
            Console.WriteLine(IsEqual(5,6));
            Console.WriteLine(IsEqual(1,1));
            Console.WriteLine(IsEqual(36,35));
        }
        public static bool IsEqual(int num1, int num2) => num1 == num2;

    }
}
