//Number of Stickers
using System;

namespace CSharpChallanges
{
    class Program34
    {
        static void Main34(string[] args)
        {
            Console.WriteLine(HowManyStickers(1));
            Console.WriteLine(HowManyStickers(2));
            Console.WriteLine(HowManyStickers(3));
        }
        public static int HowManyStickers(int n) => n * n * 6;
    }
}
