//Flip the Boolean
using System;

namespace Edabit
{
    class Program13
    {
        static void Main13(string[] args)
        {
            Console.WriteLine(Reverse(true));
            Console.WriteLine(Reverse(false));
        }
        public static bool Reverse(bool boolean) => !boolean;

    }
}
