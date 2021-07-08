//Buggy Code (Part 4)
using System;

namespace Edabit
{
    class Program41
    {
        static void Main41(string[] args)
        {
            Console.WriteLine(greeting("Matt"));
            Console.WriteLine(greeting("Helen"));
            Console.WriteLine(greeting("Mubashir"));
        }
        public static string greeting(string name) {
            if (name == "Mubashir") {
					return "Hello, my Love!";
				}
			return "Hello, " + name + "!";
	    }

    }
}
