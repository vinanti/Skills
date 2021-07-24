//Flip the Boolean
/*Create a function that reverses a boolean value.

Examples
Reverse(true) ➞ false

Reverse(false) ➞ true*/
using System;

namespace CSharpChallanges
{
    class Program13
    {
        static void Main13(string[] args)
        {
            Console.WriteLine(Reverse(true));
            Console.WriteLine(Reverse(false));
        }
        public static bool Reverse(bool boolean) => !boolean;

    }
}
