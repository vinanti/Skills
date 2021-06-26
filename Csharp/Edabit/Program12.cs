//Return Something to Me!
using System;

namespace Edabit
{
    class Program12
    {
        static void Main12(string[] args)
        {
            Console.WriteLine(GiveMeSomething("is better than nothing"));
            Console.WriteLine(GiveMeSomething("Bob Jane"));
            Console.WriteLine(GiveMeSomething("something"));
        }
        public static string GiveMeSomething(string a) => "Something " + a;
    }
}
