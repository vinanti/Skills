//Check if an Integer is Divisible By Five
using System;

namespace Edabit
{
    class Program30
    {
        static void Main30(string[] args)
        {
            Console.WriteLine(divisibleByFive(5));
            Console.WriteLine(divisibleByFive(-55));
            Console.WriteLine(divisibleByFive(37));
            Console.WriteLine(divisibleByFive(7));
            Console.WriteLine(divisibleByFive(5));
            Console.WriteLine(divisibleByFive(15));
            Console.WriteLine(divisibleByFive(33));
            Console.WriteLine(divisibleByFive(-18));
            Console.WriteLine(divisibleByFive(999));
            Console.WriteLine(divisibleByFive(2));
        }
        public static bool divisibleByFive(int n) => n%5 == 0;
    }
}
