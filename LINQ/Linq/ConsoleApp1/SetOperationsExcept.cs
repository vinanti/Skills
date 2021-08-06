﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetOperationsExceptns
{
    class SetOperationsExcept
    {
        static void Main1(string[] args)
        {
            List<string> datasource1 = new List<string>() { "A", "B", "C", "D" };
            List<string> datasource2 = new List<string>() { "C", "D", "E", "F" };

            var methodSyntax = datasource1.Except(datasource2).ToList();

            foreach (var item in methodSyntax)
                Console.WriteLine(item);

            var querySyntax = (from d in datasource1
                               select d).Except(datasource2).ToList();

            foreach (var item in querySyntax)
                Console.WriteLine(item);

            Console.WriteLine("--------------------------------------------------");
            List<Student> student = new List<Student>()
            {
                new Student(){Id =1, Name="John"},
                new Student(){Id =2, Name="Kim"},
                new Student(){Id =3, Name="John"},
                new Student(){Id =4, Name="Mark"},
                new Student(){Id =4, Name="Mark1"}
            };

            List<Student> student2 = new List<Student>()
            {
                new Student(){Id =1, Name="John"},
                new Student(){Id =2, Name="Kim"},
                new Student(){Id =5, Name="John"},
                new Student(){Id =6, Name="Mark"}
            };

            var methodSyntax2 = student.Select(s => s.Name).Except(student2.Select(s2 => s2.Name)).ToList();
            foreach (var item in methodSyntax2)
                Console.WriteLine(item);

            Console.WriteLine("--------------------------------------------------");
            //TODO: comparar operator for whole object
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}