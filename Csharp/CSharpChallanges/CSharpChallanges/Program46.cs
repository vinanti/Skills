//No Conditionals?
using System;

namespace CSharpChallanges
{
    class Program46
    {
        static void Main46(string[] args)
        {
            Console.WriteLine(Flip(0));
            Console.WriteLine(Flip(1));
        }
        public static int Flip(int y) => y == 1 ? 0 : 1;

    }
}
