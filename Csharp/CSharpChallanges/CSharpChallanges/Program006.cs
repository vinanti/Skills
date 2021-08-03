//Convert Age to Days
/*Create a function that takes the age in years and returns the age in days.

Examples
CalcAge(65) ➞ 23725

CalcAge(0) ➞ 0

CalcAge(20) ➞ 7300*/
using System;

namespace CSharpChallanges
{
    class Program006
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
