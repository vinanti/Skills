//Basketball Points
using System;

namespace CSharpChallanges
{
    class Program25
    {
        static void Main25(string[] args)
        {
            Console.WriteLine(Points(1,1));
            Console.WriteLine(Points(7,5));
            Console.WriteLine(Points(38,8));
        }
        public static int Points(int twoPointers, int threePointers) => twoPointers * 2 + threePointers * 3;

    }
}
