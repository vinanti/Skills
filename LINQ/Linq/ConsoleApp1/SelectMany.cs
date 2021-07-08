using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectionOperationns;

namespace SelectManyns
{
    class SelectMany
    {
        static void Main1(string[] args)
        {
            List<string> strList = new List<string>() { "Mihika", "Vinanti" };

            var methodResult = strList.SelectMany(x => x).ToList();

            var queryResult = (from rec in strList
                               from ch in rec
                               select ch).ToList();

            var dataSource = new List<Employee>()
            {
                new Employee(){Id=1, Name="Tom", Email="tom@gmail.com", programming = new List<string>(){"C#", "PHP", "JAVA" } },
                new Employee(){Id=2, Name="John", Email="john@gmail.com", programming = new List<string>(){"LINQ", "C#", "MVC" } },
                new Employee(){Id=3, Name="Harry", Email="harry@gmail.com", programming = new List<string>(){"LINQ", "VB", "SQL" } },
            };

            var methodSyntax = dataSource.SelectMany(emp => emp.programming).ToList();

            foreach(var item in methodSyntax)
                Console.WriteLine("Programming: " + item);

            var querySyntax = (from emp in dataSource
                               from skill in emp.programming
                               select skill).ToList();

            foreach (var item in querySyntax)
                Console.WriteLine("Programming: " + item);

            Console.ReadLine();
        }
    }
}
