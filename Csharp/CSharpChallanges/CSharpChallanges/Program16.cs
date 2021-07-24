//Basic Variable Assignment
/*A student learning C# was trying to make a function. His code should concatenate a passed string name with string "Edabit" and store it in a variable called result. He needs your help to fix this code.

Examples
nameString("Mubashir") ➞ "MubashirEdabit"

nameString("Matt") ➞ "MattEdabit"

nameString("C#") ➞ "C#Edabit"*/
using System;

namespace CSharpChallanges
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
