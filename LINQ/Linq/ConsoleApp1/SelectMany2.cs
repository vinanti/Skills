using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectionOperationns;
using static ProjectionOperationns.Employee2;

namespace SelectManyns
{
    class SelectMany2
    {
        static void Main2(string[] args)
        {
            var dataSource = new List<Employee2>()
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
                        new Techs() {Technology = "MVC" },
                        new Techs() {Technology = "C#" }
                    }},
                new Employee2(){Id=4, Name="Kim", Email="kim@gmail.com", Programming = new List<Techs>() },
                new Employee2(){Id=5, Name="Adam", Email="adam@gmail.com", Programming = new List<Techs>() },
            };

            var methodQuery = dataSource.SelectMany(emp => emp.Programming).ToList();
            foreach(var item in methodQuery)
                Console.WriteLine(item.Technology);

            var querySyntax = (from emp in dataSource
                               from pro in emp.Programming
                               select pro).ToList();
            foreach (var item in querySyntax)
                Console.WriteLine(item.Technology);
            Console.ReadLine();
        }
    }
}
