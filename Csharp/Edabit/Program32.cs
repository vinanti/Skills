//Multiple of 100

using System;

namespace Edabit
{
    class Program32
    {
        static void Main32(string[] args)
        {
            Console.WriteLine(Divisible(1));
            Console.WriteLine(Divisible(1000));
            Console.WriteLine(Divisible(100));
        }
        public static bool Divisible(int number) => number % 100 == 0;

    }
}
