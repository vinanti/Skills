//Hurdle Jump
using System;
using System.Linq;

namespace CSharpChallanges
{
    class Program45
    {
        static void Main45(string[] args)
        {
            Console.WriteLine(hurdleJump(new int[]{1, 2, 3, 4, 5}, 5));
            Console.WriteLine(hurdleJump(new int[]{5, 5, 3, 4, 5}, 3));
            Console.WriteLine(hurdleJump(new int[]{5, 4, 5, 6}, 10));
            Console.WriteLine(hurdleJump(new int[]{1,2,1}, 1));
            Console.WriteLine(hurdleJump(new int[]{3,3,3}, 4));
            Console.WriteLine(hurdleJump(new int[]{4,4}, 3));
            Console.WriteLine(hurdleJump(new int[]{}, 4));
        }
        public static bool hurdleJump(int[] hurdles, int jumpHeight) => hurdles.Where(x => x > jumpHeight).ToList().Count == 0;

    }
}
