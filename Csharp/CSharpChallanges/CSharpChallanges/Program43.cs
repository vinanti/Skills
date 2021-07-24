//Fix the Error: Check Whether a Given Number Is Odd
using System;

namespace CSharpChallanges
{
    class Program43
    {
        static void Main43(string[] args)
        {
            Console.WriteLine(IsOdd(-5));
            Console.WriteLine(IsOdd(25));
            Console.WriteLine(IsOdd(0));
        }
        public static bool IsOdd(int num) 
        {
			return Math.Abs(num) % 2 == 1;
        }

    }
}
