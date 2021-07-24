//Sum of Polygon Angles
using System;

namespace CSharpChallanges
{
    class Program21
    {
        static void Main21(string[] args)
        {
            Console.WriteLine(SumPolygon(3));
            Console.WriteLine(SumPolygon(4));
            Console.WriteLine(SumPolygon(6));
        }
        public static int SumPolygon(int num) => (num-2)*180;

    }
}
