//Area of a Triangle
using System;

namespace Edabit
{
    class Program7
    {
        static void Main7(string[] args)
        {
            Console.WriteLine(triArea(3,2));
            Console.WriteLine(triArea(7,4));
            Console.WriteLine(triArea(10,10));
        }
        public static int triArea(int b, int h) => (b * h)/2;
    }
}
