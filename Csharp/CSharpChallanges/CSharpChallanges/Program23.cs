//Maximum Edge of a Triangle
using System;

namespace CSharpChallanges
{
    class Program23
    {
        static void Main23(string[] args)
        {
            Console.WriteLine(NextEdge(8,10));
            Console.WriteLine(NextEdge(5,7));
            Console.WriteLine(NextEdge(9,2));
        }
        public static int NextEdge(int side1, int side2) => (side1 + side2) - 1;

    }
}
