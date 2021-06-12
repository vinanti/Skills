using System;

namespace myConsoleApp
{
    class Program8b
    {
        static void Main8b(string[] args)
        {
            int a = 50, b = 20;
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);

            int num = 47;

            string s = num % 2 == 0 ? "Even" : "Odd";
            Console.WriteLine(s);
        }
    }
}
