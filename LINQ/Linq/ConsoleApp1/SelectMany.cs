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

            foreach (var item in methodSyntax)
                Console.WriteLine("Programming: " + item);

            var querySyntax = (from emp in dataSource
                               from skill in emp.programming
                               select skill).ToList();

            foreach (var item in querySyntax)
                Console.WriteLine("Programming: " + item);

            List<List<int>> numbers = new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 2, 3 }, new List<int> { 3, 4 }, new List<int> { 4, 5 } };

            List<List<List<int>>> numbers2 = new List<List<List<int>>> { new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 3, 4 }, new List<int> { 5, 6 }, new List<int> { 7, 8 } }, new List<List<int>> { new List<int> { 9, 10 }, new List<int> { 11, 12 }, new List<int> { 13, 14 }, new List<int> { 15, 16 } } };

            var msNum = numbers.SelectMany(x => x).ToList();
            var msNum2 = numbers2.SelectMany(x => x.SelectMany(y => y)).ToList();

            int[] myNum = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var res1 = myNum.Select(x => x > 5); //Returned true/false value if conditiona or assign values if assigment
            var res2 = myNum.Where(x => x == 5);  //capture records which pass condition

            int[] myNum1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            

            Console.ReadLine();
        }
    }
}
