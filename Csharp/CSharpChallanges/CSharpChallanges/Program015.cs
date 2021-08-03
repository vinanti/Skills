//Are the Numbers Equal?
using System;

namespace CSharpChallanges
{
    class Program015
    {
        static void Main15(string[] args)
        {
            Console.WriteLine(IsSameNum(4,8));
            Console.WriteLine(IsSameNum(2,2));
            Console.WriteLine(IsSameNum(0,6));
        }
        public static bool IsSameNum(int num1, int num2) => num1 == num2;

    }
}
