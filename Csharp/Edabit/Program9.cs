//Is the Number Less than or Equal to Zero?
using System;

namespace Edabit
{
    class Program9
    {
        static void Main9(string[] args)
        {
            Console.WriteLine(LessThanOrEqualToZero(5));
            Console.WriteLine(LessThanOrEqualToZero(0));
            Console.WriteLine(LessThanOrEqualToZero(-2));
        }
        public static bool LessThanOrEqualToZero(double a) => a <= 0;
    }
}
