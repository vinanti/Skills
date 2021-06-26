//Power Calculator
using System;

namespace Edabit
{
    class Program5
    {
        static void Main5(string[] args)
        {
            Console.WriteLine(CircuitPower(2300, 10));
            Console.WriteLine(CircuitPower(110, 3));
            Console.WriteLine(CircuitPower(480, 20));
        }
        public static int CircuitPower(int voltage, int current) => voltage * current;
    }
}
