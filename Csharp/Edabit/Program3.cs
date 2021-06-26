//Convert Minutes into Seconds
using System;

namespace Edabit
{
    class Program3
    {
        static void Main3(string[] args)
        {
            Console.WriteLine(convert(5));
            Console.WriteLine(convert(3));
            Console.WriteLine(convert(2));
            Console.WriteLine(convert(6));
            Console.WriteLine(convert(4));
            Console.WriteLine(convert(8));
            Console.WriteLine(convert(60));
        }
        public static int convert(int minutes) => minutes * 60;
    }
}
