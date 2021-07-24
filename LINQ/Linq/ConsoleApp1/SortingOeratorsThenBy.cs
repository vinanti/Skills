using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SortingOeratorsThenBy
    {
        static void Main_SortingOeratorsThenBy(string[] args)
        { 
            var dataSource = new List<Employee>()
            {
                new Employee(){Id=3, Email="Smith@email.com", LastName="Smith", Name="Foo" },
                new Employee(){Id=2, Email="Thomas@email.com", LastName="Thomas", Name="Mark" },
                new Employee(){Id=1, Email="Allen@email.com", LastName="Allen", Name="Mark" },
                new Employee(){Id=4, Email="Anderson@email.com", LastName="Anderson", Name="Foo" }
            };

            var ms = dataSource.OrderBy(emp => emp.Name).ThenBy(emp => emp.LastName).ToList();
            foreach(var item in ms)
                Console.WriteLine(item.Id + " | " + item.Name + " | " + item.LastName);

            var qs = (from emp in dataSource
                      orderby emp.Name, emp.LastName
                      select emp).ToList();
            foreach (var item in qs)
                Console.WriteLine(item.Id + " | " + item.Name + " | " + item.LastName);

            Console.WriteLine("------------------------------------");
            var ms2 = dataSource.OrderByDescending(emp => emp.Name).ThenByDescending(emp => emp.LastName).ToList();
            foreach (var item in ms2)
                Console.WriteLine(item.Id + " | " + item.Name + " | " + item.LastName);

            var qs2 = (from emp in dataSource
                      orderby emp.Name descending, emp.LastName descending
                      select emp).ToList();
            foreach (var item in qs2)
                Console.WriteLine(item.Id + " | " + item.Name + " | " + item.LastName);
            Console.ReadLine();
        }
    }
}
