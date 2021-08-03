//Using the "&&" Operator
/*C# has a logical operator &&. The && operator takes two boolean values, and returns true if both values are true.

Consider a && b:

a is checked if it is true or false.
If a is false, false is returned.
b is checked if it is true or false.
If b is false, false is returned.
Otherwise, true is returned (as both a and b are therefore true ).
Rembember that the default value for bool is false. (eg. var c = new bool(); c is false.)
The && operator will only return true for true && true.

Make a function using the && operator.

Examples
And(true, false) ➞ false

And(true, true) ➞ true

And(false, true) ➞ false

And(false, false) ➞ false*/
using System;

namespace CSharpChallanges17
{
    class Program
    {
        static void Main17(string[] args)
        {
            Console.WriteLine(And(true, false));
            Console.WriteLine(And(true, true));
            Console.WriteLine(And(true, true));
            Console.WriteLine(And(false, false));
        }
        public static bool And(bool x, bool y) => x && y;

    }
}
