//Count the Letters and Digits
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Edabit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ount_all("Hello World"));
            Console.WriteLine(ount_all("H3ll0 Wor1d"));
            Console.WriteLine(ount_all("149990"));
            Console.WriteLine(ount_all("      "));
        }
        public static string ount_all(string txt) 
        {	 	
			int letters = txt.ToCharArray().Count(c => Char.IsLetter(c));
            int numbers = txt.ToCharArray().Count(c => Char.IsNumber(c));
            return "{ Letters = " +  letters + ", DIGITS = " + numbers + " }";
        }
    }
}
