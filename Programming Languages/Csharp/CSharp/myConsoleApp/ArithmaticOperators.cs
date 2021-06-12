using System;

namespace myConsoleApp
{
    class Program8a
    {
        static void Main8a(string[] args)
        {
            //Arithmatic Operators
            int a = 100, b = 20;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            //Precedance
            int x = 10, y = 20, z=5;
            int ans = x + y * z;
            Console.WriteLine(ans);

            int marks = 72, max = 80;
            int perc = marks / max * 100;
            Console.WriteLine(perc);
            perc = marks * 100/ max;
            Console.WriteLine(perc);
/*
            int a = 10;
            a = a + 5;
            Console.WriteLine(a);
            a += 5;
            Console.WriteLine(a);
            a += 5;
            Console.WriteLine(a);

            int x = 10;
            int y = x++;
            Console.WriteLine(x);
            Console.WriteLine(y);

            x = 10;
            y = ++x;
            Console.WriteLine(x);
            Console.WriteLine(y);
*/
        }
    }
}
