using System;

namespace myConsoleApp
{
    class Program12
    {
        static void Main12(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());
            string s = ch.ToString().ToLower();
            switch(s)
            {
                case "a":
                    Console.WriteLine("a is vowel");
                    break;
                case "e":
                    Console.WriteLine("a is vowel");
                    break;
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("a is vowel");
                    break;
                default:
                    Console.WriteLine("Consonant /Special charaters");
                    break;
            }
        }
    }
}
