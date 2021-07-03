//Inches to Feet
using System;

namespace Edabit
{
    class Program24
    {
        static void Main24(string[] args)
        {
            Console.WriteLine(inchesToFeet(324));
            Console.WriteLine(inchesToFeet(12));
            Console.WriteLine(inchesToFeet(36));
        }
        public static int inchesToFeet(int inches) => inches/12;

    }
}
