using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class QuantifierOperationAny
    {
        static void Main_QuantifierOperationAny(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            var isAvailable = numbers.Any();
            Console.WriteLine(isAvailable);
            Console.WriteLine("--------------------------------------------------");
            Student[] students = { new Student { Name = "Kim", Marks = 90,
                                                    Subject = new List<Subject>(){
                                                        new Subject(){SubjectName = "Math", SubjectMarks=75},
                                                        new Subject(){SubjectName = "English", SubjectMarks=80},
                                                        new Subject(){SubjectName = "Art", SubjectMarks=86},
                                                        new Subject(){SubjectName = "History", SubjectMarks=91},
                                                    } },
                                new Student { Name = "John", Marks = 80,
                                                    Subject = new List<Subject>(){
                                                        new Subject(){SubjectName = "Math", SubjectMarks=89},
                                                        new Subject(){SubjectName = "English", SubjectMarks=91},
                                                        new Subject(){SubjectName = "Art", SubjectMarks=90},
                                                        new Subject(){SubjectName = "History", SubjectMarks=91},
                                                    } },
                                new Student { Name = "Lee", Marks = 75,
                                                    Subject = new List<Subject>(){
                                                        new Subject(){SubjectName = "Math", SubjectMarks=75},
                                                        new Subject(){SubjectName = "English", SubjectMarks=80},
                                                        new Subject(){SubjectName = "Art", SubjectMarks=60},
                                                        new Subject(){SubjectName = "History", SubjectMarks=91},
                                                    } } };

            //Does any student has marks more than 90%?
            var ms = students.Any(s => s.Marks > 90);
            Console.WriteLine(ms);

            var qs = (from s in students
                      select s).Any(x => x.Marks > 85);
            Console.WriteLine(qs);
            Console.WriteLine("--------------------------------------------------");
            //EX: does any student has marks more than 90% in any subject
            var ms1 = students.Where(std => std.Subject.Any(m => m.SubjectMarks > 90)).Select(std => std.Name).ToList();
            foreach(var item in ms1)
                Console.WriteLine(item);

            var qs1 = (from std in students
                       where std.Subject.Any(m => m.SubjectMarks > 90)
                       select std.Name);
            foreach (var item in ms1)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }

}
