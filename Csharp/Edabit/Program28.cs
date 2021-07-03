//Stack the Boxes
using System;

namespace Edabit
{
    class Program28
    {
        static void Main28(string[] args)
        {
            Console.WriteLine(StackBoxes(1));
            Console.WriteLine(StackBoxes(2));
            Console.WriteLine(StackBoxes(0));
        }
        public static int StackBoxes(int n) => (int)Math.Pow(n,2);
    }
}
