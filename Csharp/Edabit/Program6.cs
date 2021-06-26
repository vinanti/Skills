//Convert Age to Days
using System;

namespace Edabit
{
    class Program6
    {
        static void Main6(string[] args)
        {
            Console.WriteLine(CalcAge(65));
            Console.WriteLine(CalcAge(0));
            Console.WriteLine(CalcAge(20));
        }
        public static int CalcAge(int age) => age * 365;
    }
}
