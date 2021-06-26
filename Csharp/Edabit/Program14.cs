//Convert Hours into Seconds
using System;

namespace Edabit
{
    class Program14
    {
        static void Main14(string[] args)
        {
            Console.WriteLine(HowManySeconds(2));
            Console.WriteLine(HowManySeconds(10));
            Console.WriteLine(HowManySeconds(24));
        }
        public static int HowManySeconds(int hours) => hours * 60 * 60;

    }
}
