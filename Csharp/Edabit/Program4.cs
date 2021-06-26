//Return the Next Number from the Integer Passed
using System;

namespace Edabit
{
    class Program4
    {
        static void Main4(string[] args)
        {
            Console.WriteLine(Addition(0));
            Console.WriteLine(Addition(9));
            Console.WriteLine(Addition(-3));
        }
        public static int Addition(int num) => ++num;
    }
}
