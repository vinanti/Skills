//Using the "&&" Operator
using System;

namespace Edabit17
{
    class Program
    {
        static void Main17(string[] args)
        {
            Console.WriteLine(And(true, false));
            Console.WriteLine(And(true, true));
            Console.WriteLine(And(true, true));
            Console.WriteLine(And(false, false));
        }
        public static bool And(bool x, bool y) => x && y;

    }
}
