//Return the Remainder from Two Numbers
using System;

namespace Edabit
{
    class Program8
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
