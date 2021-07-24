//Return Something to Me!
/*Write a function that returns the string "something" joined with a space " " and the given argument a.

Examples
GiveMeSomething("is better than nothing") ➞ "something is better than nothing"

GiveMeSomething("Bob Jane") ➞ "something Bob Jane"

GiveMeSomething("something") ➞ "something something"*/
using System;

namespace CSharpChallanges
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
