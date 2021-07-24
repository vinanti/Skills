//Max Min Difference
using System;
using System.Linq;

namespace CSharpChallanges
{
    class Program37
    {
        static void Main37(string[] args)
        {
            Console.WriteLine(Diff(new int[] {10, 15, 20, 2, 10, 6}));
            Console.WriteLine(Diff(new int[] {-3, 4, -9, -1, -2, 15}));
            Console.WriteLine(Diff(new int[] {4, 17, 12, 2, 10, 2}));
        }
        public static int Diff(int[] arr) => arr.Max() - arr.Min();

    }
}
