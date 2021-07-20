using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program2
    {
        static void Main2(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<Employee> employee = new List<Employee>()
            {
                new Employee(){Id=1, Name="Tom"},
                new Employee(){Id=2, Name="John"}
            };

            IEnumerable<Employee> query = from emp in employee
                                          where emp.Id == 1
                                          select emp;

            foreach(var item in query)
                Console.WriteLine("Id:" + item.Id + " Name:" + item.Name);

            IEnumerable<int> querySysntax = from obj in list
                               where obj > 5
                               select obj;

            IQueryable<Employee> query1 = employee.AsQueryable().Where(x => x.Id == 1);

            foreach (var item in query1)
                Console.WriteLine("Id:" + item.Id + " Name:" + item.Name);
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; internal set; }
    }
}
