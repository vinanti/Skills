using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectionOperationns;

namespace ConsoleApp1
{
    class SortingOperatorsOrderByDescending
    {
        static void Main_SortingOperatorsOrderByDescending(string[] args)
        {
            var dataSourceInt = new List<int>() { 5, 12, 13, 1, 7, 53, 100 };
            //Ex. set data in descending order
            var querySyntax = (from num in dataSourceInt
                               where num > 10
                               orderby num descending
                               select num).ToList();
            foreach(var item in querySyntax)
                Console.WriteLine(item);

            var methodSyntax = dataSourceInt.Where(num => num > 10).OrderByDescending(num => num).ToList();
            foreach (var item in methodSyntax)
                Console.WriteLine(item);
            Console.WriteLine("----------------------------------------");
            
            var dataSourceString = new List<string>() { "Smith", "Anderson", "Wright", "Mitchell","Thomas","Allen","Evans", "Collins" };
            //Ex. set data in assending order
            var querySyntax2 = (from name in dataSourceString
                                where name.Length > 5
                               orderby name descending
                               select name).ToList();
            foreach (var item in querySyntax2)
                Console.WriteLine(item);

            var methodSyntax2 = dataSourceString.Where(name => name.Length > 5).OrderByDescending(num => num).ToList();
            foreach (var item in methodSyntax2)
                Console.WriteLine(item);
            Console.WriteLine("----------------------------------------");

            var dataSource = new List<Employee2>()
            {
                new Employee2(){Id=1, Name="Tom", Email="tom@gmail.com"},
                new Employee2(){Id=2, Name="John", Email="john@gmail.com"},
                new Employee2(){Id=3, Name="Mark", Email="mark@gmail.com"},
                new Employee2(){Id=4, Name="Kim", Email="kim@gmail.com"},
                new Employee2(){Id=5, Name="Adam", Email="adam@gmail.com"},
            };

            var querySyntax3 = (from emp in dataSource
                                where emp.Id > 2
                               orderby emp.Name descending
                               select emp).ToList();
            foreach (var item in querySyntax3)
                Console.WriteLine(item.Name);

            var methodSyntax3 = dataSource.Where(emp => emp.Id > 2).OrderByDescending(emp => emp.Name).ToList();
            foreach (var item in methodSyntax3)
                Console.WriteLine(item.Name);

            Console.ReadLine();
        }
    }
}
