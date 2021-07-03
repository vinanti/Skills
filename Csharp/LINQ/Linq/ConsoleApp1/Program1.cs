using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program1
    {
        static void Main1(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //1. Query Syntax
            Console.WriteLine("1. Query Syntax");
            var querySysntax = from l in list
                               where l > 5
                               select l;

            foreach(var item in querySysntax)
                Console.WriteLine(item);

            //2. Method Syntax using Lamda Expression
            Console.WriteLine("2. Method Syntax");
            var methodSyntax = list.Where(l => l < 5);
            foreach (var item in methodSyntax)
                Console.WriteLine(item);

            var max = list.Max();
            Console.WriteLine("Max:" + max);

            //3. Mixed syntax
            Console.WriteLine("3. Mixed syntax");
            var mixedSyntax = (from l in list
                               select l).Max();
            Console.WriteLine("Max in list: " + mixedSyntax);
        }
    }
}
