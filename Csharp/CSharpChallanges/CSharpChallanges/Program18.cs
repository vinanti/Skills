//Find the Perimeter of a Rectangle
/*Create a function that takes length and width and finds the perimeter of a rectangle.

Examples
FindPerimeter(6, 7) ➞ 26

FindPerimeter(20, 10) ➞ 60

FindPerimeter(2, 9) ➞ 22*/
using System;

namespace CSharpChallanges
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
