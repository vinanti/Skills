//Name Greeting!
/*Create a function that takes a name and returns a greeting in the form of a string.

Examples
HelloName("Gerald") ➞ "Hello Gerald!"

HelloName("Tiffany") ➞ "Hello Tiffany!"

HelloName("Ed") ➞ "Hello Ed!"*/
using System;

namespace CSharpChallanges
{
    class Program22
    {
        static void Main22(string[] args)
        {
            Console.WriteLine(HelloName("Gerald"));
            Console.WriteLine(HelloName("Tiffany"));
            Console.WriteLine(HelloName("Ed"));
        }
        public static string HelloName(string name) => String.Concat("Hello ",name);

    }
}
