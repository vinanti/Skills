using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class FilteringOperatorOfType
    {
        static void Main_FilteringOperatorOfType(string[] args)
        {
            var dataSource = new List<object> {"Adam", "Harry", "Kim", "John", 1, 2, 3, 4, 5};

            //Ex. Fetch only those records who are of type string
            var methodSyntax = dataSource.OfType<string>().ToList();
            foreach (var item in methodSyntax)
                Console.WriteLine(item);

            var querySyntax = (from x in dataSource
                               where x is string
                               select x).ToList();
            foreach (var item in querySyntax)
                Console.WriteLine(item);

            Console.WriteLine("----------------------------------------");
            //get only those records who has length 4 and type string
            var methodSyntax2 = dataSource.OfType<string>().Where(x => x.Length > 3).ToList();
            foreach (var item in methodSyntax2)
                Console.WriteLine(item);

            var querySyntax2 = (from x in dataSource
                               where x is string
                                && x.ToString().Length >3
                               select x).ToList();
            foreach (var item in querySyntax2)
                Console.WriteLine(item);
            System.Console.ReadLine();
        }
    }
}