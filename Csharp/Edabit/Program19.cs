//The Farm Problem
using System;

namespace Edabit
{
    class Program19
    {
        static void Main19(string[] args)
        {
            Console.WriteLine(animals(2,3,5));
            Console.WriteLine(animals(1,2,3));
            Console.WriteLine(animals(5,2,8));
        }
        public static int animals(int chickens, int cows, int pigs) => (chickens*2 + cows*4 + pigs*4);

    }
}
