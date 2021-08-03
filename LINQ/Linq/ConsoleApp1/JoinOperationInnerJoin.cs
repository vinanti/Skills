using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinOperationInnerJoinns
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
    }
    class Address
    {
        public int Id { get; set; }
        public String AddressLine { get; set; }
    }
    class Marks
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int TMarks { get; set; }
    }
    class JoinOperationInnerJoin
    {
        static void Main5(string[] args)
        {
            var students = new List<Student>()
            {
                new Student(){Id = 1, Name = "A 1", AddressId = 1},
                new Student(){Id = 2, Name = "A 2", AddressId = 0},
                new Student(){Id = 3, Name = "A 3", AddressId = 2},
                new Student(){Id = 4, Name = "A 4", AddressId = 0},
                new Student(){Id = 5, Name = "A 5", AddressId = 3},
            };

            var addressess = new List<Address>()
            {
                new Address(){Id = 1, AddressLine = "1"},
                new Address(){Id = 2, AddressLine = "2"},
                new Address(){Id = 3, AddressLine = "3"},
                new Address(){Id = 4, AddressLine = "4"},
                new Address(){Id = 5, AddressLine = "5"},
            };

            var marks = new List<Marks>()
            {
                new Marks(){Id = 1, StudentId = 1, TMarks = 80},
                new Marks(){Id = 2, StudentId = 1, TMarks = 90},
                new Marks(){Id = 3, StudentId = 1, TMarks = 95},
            };

            var qs = (from student in students
                      join address in addressess
                      on student.AddressId equals address.Id
                      select new
                      {
                          StudentName = student.Name,
                          Line = address.AddressLine
                      }).ToList();

            var ms = students.Join(addressess, std => std.AddressId, add => add.Id,
                                    (std, add) => new
                                    {
                                        StudentName = std.Name,
                                        Line = add.AddressLine
                                    }).ToList();

            var qs2 = (from student in students
                      join address in addressess
                      on student.AddressId equals address.Id
                      join mark in marks
                      on student.Id equals mark.StudentId
                      select new
                      {
                          StudentName = student.Name,
                          Line = address.AddressLine,
                          TotalMarks = mark.TMarks
                      }).ToList();

            //var ms2 = students.Join(addressess, std => std.AddressId, add => add.Id,
            //                        (std, add) => new {std, add})
            //                        .Join(marks, std => std.std.Id)
            Console.ReadLine();
        }
    }

}
