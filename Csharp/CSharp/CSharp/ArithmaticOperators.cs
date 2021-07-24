using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmaticOperators
{
    class ArithmaticOperators
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Arithmatic Operators");
            int a = 50, b = 10, c = 5;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.WriteLine("------------------------1");

            int d = a + b * c;
            Console.WriteLine(d);
            Console.WriteLine("------------------------2");

            int a1 = 10, b1 = 20, c1 = 5;
            int d1 = a1 + b1 * c1;
            Console.WriteLine(d1);
            Console.WriteLine("------------------------3");

            int marks = 72, max = 80;
            int perc = marks / max * 100;
            Console.WriteLine(perc);
            Console.WriteLine("------------------------4");

            perc = marks * 100 / max;
            Console.WriteLine(perc);
            Console.WriteLine("------------------------5");

            int a2 = 10;
            a2 = a2 + 5;
            Console.WriteLine(a2);
            a2 += 5;
            Console.WriteLine(a2);
            a2++;
            Console.WriteLine(a2);
            Console.WriteLine("------------------------6");

            int a3 = 10;
            int b3 = ++a3;
            Console.WriteLine(a3);
            Console.WriteLine(b3);
            Console.WriteLine("------------------------7");

            int a4 = 10;
            int b4 = a4++;
            Console.WriteLine(a4);
            Console.WriteLine(b4);
            Console.WriteLine("------------------------7\n\n\n");
        }
    }
}
