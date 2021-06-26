//Return the Sum of Two Numbers
using System;

namespace Edabit
{
    class Program2
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
