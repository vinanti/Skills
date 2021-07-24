using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchns
{
    class Switch
    {
        static void Main1(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());
            string s = ch.ToString().ToLower();
            switch(s)
            {
                case "a":
                    Console.WriteLine("a as vowel");
                    break;
                case "e":
                    Console.WriteLine("e as vowel");
                    break;
                case "i":
                    Console.WriteLine("i as vowel");
                    break;
                case "o":
                    Console.WriteLine("o as vowel");
                    break;
                case "u":
                    Console.WriteLine("u as vowel");
                    break;
                default:
                    Console.WriteLine("Constant / Special character]1");
                    break;
            }
            Console.WriteLine("------------------------1");
            switch (s)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine(s + " as vowel");
                    break;
                default:
                    Console.WriteLine("Constant / Special character");
                    break;
            }
            Console.WriteLine("------------------------2");
        }
    }
}
