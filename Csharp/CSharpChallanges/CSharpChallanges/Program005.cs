//Power Calculator
/*Create a function that takes voltage and current and returns the calculated power.

Examples
CircuitPower(230, 10) ➞ 2300

CircuitPower(110, 3) ➞ 330

CircuitPower(480, 20) ➞ 9600*/
using System;

namespace CSharpChallanges
{
    class Program005
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
