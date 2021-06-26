//Less Than 100?
using System;

namespace Edabit
{
    class Program10
    {
        static void Main10(string[] args)
        {
            Console.WriteLine(lessThan100(22,15));
            Console.WriteLine(lessThan100(83,34));
            Console.WriteLine(lessThan100(3,77));
        }
        public static bool lessThan100(int a, int b) => (a + b) < 100;
    }
}
