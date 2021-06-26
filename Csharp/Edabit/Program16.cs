//Basic Variable Assignment
using System;

namespace Edabit
{
    class Program16
    {
        static void Main16(string[] args)
        {
            Console.WriteLine(nameString("Mubashir"));
            Console.WriteLine(nameString("Matt"));
            Console.WriteLine(nameString("C#"));
        }
        public static string nameString(string name) {
		    string b = "Edabit";
		    string result = name + b;
		    return result;
	    }
    }
}
