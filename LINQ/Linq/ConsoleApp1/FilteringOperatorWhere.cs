using ProjectionOperationns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjectionOperationns.Employee2;

namespace ConsoleApp1
{
    class FilteringOperatorWhere
    {
        static void Main_FilteringOperatorWhere(string[] args)
        {
            var dataSource = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Ex. get all elemets which are greator than 5
            var querySyntx = (from n in dataSource
                             where n > 5
                             select n).ToList();
            foreach(var d in querySyntx)
                Console.WriteLine(d);

            var methodSyntax = dataSource.ToList().IndexOf(dataSource.Where(n => n >= 11).FirstOrDefault());
            //foreach (var d in methodSyntax)
                Console.WriteLine(methodSyntax);

            Console.WriteLine("----------------------------------------");
            //Ex. get all elemets which are less than equal 5 or greater than 9
            var querySyntx2 = (from n in dataSource
                              where n <= 5 || n > 9
                              select n).ToList();
            foreach (var d in querySyntx2)
                Console.WriteLine(d);

            var methodSyntax2 = dataSource.Where(n => n <= 5 || n > 9).ToList();
            foreach (var d in methodSyntax2)
                Console.WriteLine(d);

            Console.WriteLine("----------------------------------------");
            //Ex. print records whose length is 3
            var dataSource3 = new List<string>() { "Tom", "Harry", "Adam", "Ponting", "Sachin" };

             var querySyntx3 = (from str in dataSource3
                                where str.Length == 3
                                select str).ToList();
            foreach (var d in querySyntx3)
                Console.WriteLine(d);

            var methodSyntax3 = dataSource3.Where(str => str.Length == 3).ToList();
            foreach (var d in methodSyntax3)
                Console.WriteLine(d);

            Console.WriteLine("----------------------------------------");
            //Ex. print records whose name is Tom or Lrnth > 5
            var dataSource4 = new List<string>() { "Tom", "Harry", "Adam", "Ponting", "Sachin" };

            var querySyntx4 = (from str in dataSource4
                               where str == "Tom" || str.Length > 5
                               select str).ToList();
            foreach (var d in querySyntx4)
                Console.WriteLine(d);

            var methodSyntax4 = dataSource4.Where(str => str == "Tom" || str.Length > 5).ToList();
            foreach (var d in methodSyntax4)
                Console.WriteLine(d);

            Console.WriteLine("----------------------------------------");
            //Ex. print records whose has no technologies
            var dataSource5 = new List<Employee2>()
            {
                new Employee2(){Id=1, Name="Tom", Email="tom@gmail.com", Programming =
                    new List<Techs>{
                        new Techs() {Technology = "C#", },
                        new Techs() {Technology = "PHP" },
                        new Techs() {Technology = ".Net" }
                    }},
                new Employee2(){Id=2, Name="John", Email="john@gmail.com", Programming =
                    new List<Techs>{
                        new Techs() {Technology = "C#", },
                        new Techs() {Technology = "VB" },
                        new Techs() {Technology = "SQL" }
                    }},
                new Employee2(){Id=3, Name="Mark", Email="mark@gmail.com", Programming =
                    new List<Techs>{
                        new Techs() {Technology = "LINQ", },
                        new Techs() {Technology = "MVC" }
                    }},
                new Employee2(){Id=4, Name="Kim", Email="kim@gmail.com", Programming = new List<Techs>() },
                new Employee2(){Id=5, Name="Adam", Email="adam@gmail.com", Programming = new List<Techs>() },
            };

            var querySyntax5 = (from emp in dataSource5
                                where emp.Programming.Count == 0
                                select emp.Name).ToList();
            foreach (var d in querySyntax5)
                Console.WriteLine(d);

            var methodSyntx5 = dataSource5.Where(emp => emp.Programming.Count == 2).ToList();
            foreach (var d in methodSyntx5)
                Console.WriteLine(d.Name);
            Console.ReadLine();
        }
    }
}
