//Find the Perimeter of a Rectangle
using System;

namespace Edabit
{
    class Program18
    {
        static void Main18(string[] args)
        {
            Console.WriteLine(FindPerimeter(6,7));
            Console.WriteLine(FindPerimeter(20,10));
            Console.WriteLine(FindPerimeter(2,9));
        }
        public static int FindPerimeter(int length, int width) => 2 * (length + width);

    }
}
