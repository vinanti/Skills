//Name Greeting!
using System;

namespace Edabit
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
