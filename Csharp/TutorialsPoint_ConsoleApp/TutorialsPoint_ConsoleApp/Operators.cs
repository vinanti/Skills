using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialsPoint_ConsoleApp
{
    class Operators
    {
        static void Main(string[] args)
        {
            //Arithmatic Operators
            int a = 50, b = 10, c = 5;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            int d = a + b * c;
            Console.WriteLine(d);

        }
    }
}
