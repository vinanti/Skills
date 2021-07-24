using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class QuantifierOperationAll
    {
        static void Main_QuantifierOperationAll(string[] args)
        {
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

            //Check all students have greater than 70%
            var ms = students.All(s => s.Marks > 70);
            Console.WriteLine(ms);

            var qs = (from s in students
                      select s).All(m => m.Marks < 70);
            Console.WriteLine(qs);

            Console.WriteLine("-----------------------------------");
            //Fech all records who has >70 marks in all the subjects
            var ms2 = students.Where(s => s.Subject.All(m => m.SubjectMarks > 70)).ToList();

            foreach(var item in ms2)
                Console.WriteLine(item.Name);

            var qs2 = (from s in students
                       where s.Subject.All(m => m.SubjectMarks > 70)
                       select s).ToList();
            foreach (var item in qs2)
                Console.WriteLine(item.Name);
            Console.ReadLine();
        }
    }
    class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
        public List<Subject> Subject { get; set; }
    }
    class Subject
    {
        public string SubjectName { get; set; }
        public int SubjectMarks { get; set; }
    };
}
