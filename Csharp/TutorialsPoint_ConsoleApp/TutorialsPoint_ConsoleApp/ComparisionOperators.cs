using System;                                                                                                                                                                                                                using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialsPoint_ConsoleApp
{
    class ComparisionOperators
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Comparision Operators");
            int a = 50, b = 20;
            Console.WriteLine(a > b); //true
            Console.WriteLine(a < b); //false
            Console.WriteLine(a >= b); //true
            Console.WriteLine(a <= b); //false
            Console.WriteLine(a == b); //false
            Console.WriteLine(a != b); //true
            Console.WriteLine("------------------------1");
            int num = 46;
            string s = num % 2 == 0 ? "Even" : "Odd";
            Console.WriteLine(s);
            Console.WriteLine("------------------------2");
            
        }
    }
}
