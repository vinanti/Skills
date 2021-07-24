//Area of a Rectangle
using System;

namespace CSharpChallanges
{
    class Program33
    {
        static void Main33(string[] args)
        {
            Console.WriteLine(area(3,4));
            Console.WriteLine(area(10,11));
            Console.WriteLine(area(-1,5));
            Console.WriteLine(area(0,2));
        }
        public static int area(int h, int w)
        {
            if(h<=0 || w<=0)
                return -1;
            else
                return h*w;
        }
    }
}
