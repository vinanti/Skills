using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SortingOeratorsThenBy
    {
        static void Main(string[] args)
        { 
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id=3, Email="tom@gmail.com", Name="Tom", },
                new Employee(){Id=1, Name="Tom", Email="tom@gmail.com"},
                new Employee(){Id=2, Name="John", Email="john@gmail.com"},
                new Employee(){Id=3, Name="Mark", Email="mark@gmail.com"},
                new Employee(){Id=4, Name="Kim", Email="kim@gmail.com"},
                new Employee(){Id=5, Name="Adam", Email="adam@gmail.com"}
            };
        }
    }
}
