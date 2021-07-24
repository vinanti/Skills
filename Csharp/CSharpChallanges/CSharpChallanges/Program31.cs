//Flip the Integer Boolean
using System;

namespace CSharpChallanges
{
    class Program31
    {
        static void Main31(string[] args)
        {
            Console.WriteLine(FlipIntBool(1));
            Console.WriteLine(FlipIntBool(0));
        }
        public static int FlipIntBool(int ib) => Convert.ToBoolean(ib)?0:1;
    }
}
