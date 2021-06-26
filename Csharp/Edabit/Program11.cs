//Are the Numbers Equal?
using System;

namespace Edabit
{
    class Program11
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
