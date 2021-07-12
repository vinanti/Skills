using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FilteringOperatorWhere
    {
        static void Main(string[] args)
        {
            var dataSource = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Ex. get all elemets which are greator than 5
            var querySyntx = (from n in dataSource
                             where n > 5
                             select n).ToList();
            foreach(var d in querySyntx)
                Console.WriteLine(d);

            var methodSyntax = dataSource.Where(n=> n > 5).ToList();
            foreach (var d in methodSyntax)
                Console.WriteLine(d);

            Console.ReadLine();
        }
    }
}
