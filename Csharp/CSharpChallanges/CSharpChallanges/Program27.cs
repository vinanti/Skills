//Frames Per Second
using System;

namespace CSharpChallanges
{
    class Program27
    {
        static void Main27(string[] args)
        {
            Console.WriteLine(Frames(1,1));
            Console.WriteLine(Frames(10,1));
            Console.WriteLine(Frames(10,25));
        }
        public static int Frames(int minutes, int fps) => minutes * 60 * fps;

    }
}
