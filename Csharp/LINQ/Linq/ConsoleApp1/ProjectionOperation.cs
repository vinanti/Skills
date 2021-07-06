using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectionOperationns
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id=1, Name="Tom", Email="tom@gmail.com"},
                new Employee(){Id=2, Name="John", Email="john@gmail.com"},
                new Employee(){Id=3, Name="Mark", Email="mark@gmail.com"},
                new Employee(){Id=4, Name="Kim", Email="kim@gmail.com"},
                new Employee(){Id=5, Name="Adam", Email="adam@gmail.com"}
            };
            //Ex - Select all data in one time
            Console.WriteLine("----------------------------------------");
            var basicQuery = (from emp in employees
                             select emp).ToList();
            foreach (var item in basicQuery)
                Console.WriteLine("Id:" + item.Id + " Name:" + item.Name);

            Console.WriteLine("----------------------------------------");
            var basicQueryList = (from emp in employees
                              select emp).ToList();
            foreach (var item in basicQueryList)
                Console.WriteLine("Id:" + item.Id + " Name:" + item.Name);

            Console.WriteLine("----------------------------------------");
            var basicMethod = employees;
            foreach (var item in basicMethod)
                Console.WriteLine("Id:" + item.Id + " Name:" + item.Name);

            Console.WriteLine("----------------------------------------");
            var basicMethodList = employees.ToList();
            foreach (var item in basicMethodList)
                Console.WriteLine("Id:" + item.Id + " Name:" + item.Name);

            //Operations
            //Ex. to get List of integer of Id
            Console.WriteLine("----------------------------------------");
            var basicPropQuery = (from emp in employees
                                  select emp.Id).ToList();
            foreach (var item in basicPropQuery)
                Console.WriteLine("Id:" + item);


            Console.WriteLine("----------------------------------------");
            var basicPropMethod = employees.Select(emp => emp.Id).ToList();
            foreach (var item in basicPropQuery)
                Console.WriteLine("Id:" + item);

            //Ex. to increse Id by 1
            Console.WriteLine("----------------------------------------");
            var basicPropQuery1 = (from emp in employees
                                  select emp.Id + 1).ToList();
            foreach (var item in basicPropQuery1)
                Console.WriteLine("Id:" + item);


            Console.WriteLine("----------------------------------------");
            var basicPropMethod1 = employees.Select(emp => emp.Id + 1).ToList();
            foreach (var item in basicPropMethod1)
                Console.WriteLine("Id:" + item);

            //Ex. Conver Id from integer to string
            //Ex. to get List of integer of Id
            Console.WriteLine("----------------------------------------");
            var basicPropQuery2 = (from emp in employees
                                  select emp.Id.ToString()).ToList();
            foreach (var item in basicPropQuery2)
                Console.WriteLine("Id:" + item);


            Console.WriteLine("----------------------------------------");
            var basicPropMethod2 = employees.Select(emp => emp.Id.ToString()).ToList();
            foreach (var item in basicPropMethod2)
                Console.WriteLine("Id:" + item);

            //Ex. Fetch all records with only 2 properties Id and email
            Console.WriteLine("----------------------------------------");
            var selectQuery = from emp in employees
                              select new Employee()
                              {
                                  Id = emp.Id,
                                  Email = emp.Email
                              };
            foreach (var item in selectQuery)
                Console.WriteLine($"Id: { item.Id}, Name: {item.Name} Email: {item.Email}");

            //Convert Data to some other class - Student
            Console.WriteLine("----------------------------------------");
            var selectQueryStudent = from emp in employees
                              select new Student()
                              {
                                  StudentId = emp.Id,
                                  StEmail = emp.Email,
                                  FullName = emp.Name
                              };
            foreach (var item in selectQueryStudent)
                Console.WriteLine($"Id: { item.StudentId}, Name: {item.FullName} Email: {item.StEmail}");

            Console.WriteLine("----------------------------------------");
            var selectMethodStudent = employees.Select(emp => new Student 
                            { 
                                FullName = emp.Name, 
                                StEmail = emp.Email, 
                                StudentId = emp.Id 
                            }).ToList();
            foreach (var item in selectMethodStudent)
                Console.WriteLine($"Id: { item.StudentId}, Name: {item.FullName} Email: {item.StEmail}");

            //Anonums method
            Console.WriteLine("----------------------------------------");
            var selectQueryAnonums = (from emp in employees
                                      select new
                                      {
                                          CId = emp.Id,
                                          CEmail = emp.Email,
                                          CName = emp.Name
                                      }).ToList();
            foreach (var item in selectQueryAnonums)
                Console.WriteLine($"Id: { item.CId}, Name: {item.CName} Email: {item.CEmail}");

            Console.WriteLine("----------------------------------------");
            var selectQueryMethodAnonums = employees.Select(emp => new
                                      {
                                          CId = emp.Id,
                                          CEmail = emp.Email,
                                          CName = emp.Name
                                      }).ToList();
            foreach (var item in selectQueryMethodAnonums)
                Console.WriteLine($"Id: { item.CId}, Name: {item.CName} Email: {item.CEmail}");

            //select data by using index
            Console.WriteLine("----------------------------------------");
            var queryIndex = employees.Select((emp, Index) => new { Index = Index, Name = emp.Name }).ToList();
            Console.ReadLine();
        }
    }
}
