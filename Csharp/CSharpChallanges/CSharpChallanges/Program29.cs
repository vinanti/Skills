//Convert Hours and Minutes into Seconds
using System;

namespace CSharpChallanges
{
    class Program29
    {
        static void Main29(string[] args)
        {
            Console.WriteLine(Convert(1,3));
            Console.WriteLine(Convert(2,0));
            Console.WriteLine(Convert(0,0));
            Console.WriteLine(Convert(1,0));
            Console.WriteLine(Convert(1,3));
            Console.WriteLine(Convert(0,30));
        }
        public static int Convert(int hours, int minutes) => (hours * 60 * 60) + (minutes * 60);
    }
}
