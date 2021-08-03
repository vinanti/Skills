//Area of a Triangle
/*Write a function that takes the base and height of a triangle and return its area.

Examples
triArea(3, 2) ➞ 3

triArea(7, 4) ➞ 14

triArea(10, 10) ➞ 50
Notes
The area of a triangle is: (base * height) / 2*/
using System;

namespace CSharpChallanges
{
    class Program007
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
