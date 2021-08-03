using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetOperationsDistinctns
{
    class SetOperationsDistinct
    {
        static void Main1(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 1, 2, 3, 4, 5, 3, 5, 5, 5 };

            var methodSyntax = numbers.Distinct().ToList();

            foreach (var item in methodSyntax)
                Console.WriteLine(item);

            var querySyntax = (from n in numbers
                               select n).Distinct().ToList();

            foreach (var item in querySyntax)
                Console.WriteLine(item);

            Console.WriteLine("--------------------------------------------------");

            List<Student> student = new List<Student>()
            {
                new Student(){Id =1, Name="John"},
                new Student(){Id =2, Name="Kim"},
                new Student(){Id =3, Name="John"},
                new Student(){Id =4, Name="Kim"}
            };

            var methodSyntax2 = student.Select(s => s.Name).Distinct().ToList();

            foreach (var item in methodSyntax2)
                Console.WriteLine(item);

            var querySyntax2 = (from n in student
                                select n.Name).Distinct().ToList();

            foreach (var item in querySyntax2)
                Console.WriteLine(item);

            Console.WriteLine("--------------------------------------------------");
            //TODO: comparar operator

        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
