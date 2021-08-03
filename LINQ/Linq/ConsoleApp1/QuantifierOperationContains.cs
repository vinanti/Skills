using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantifierOperationContainsns
{
    class QuantifierOperationContains
    {
        static void Main1(string[] args)
        {
            List<string> student1 = new List<string>() { "Kim", "Jacob", "Simon", "John" };

            //Ex. Kim exists in list?
            var methodSysntax = student1.AsEnumerable().Contains("Vinanti");
            Console.WriteLine(methodSysntax);

            var querySyntax = (from s in student1
                               select s).Contains("Kim");
            Console.WriteLine(querySyntax);

            //
            List<Student> student2 = new List<Student>()
            {
                new Student(){Id = 1, Name="Kim"},
                new Student(){Id = 2, Name="John"}
            };

            var isExistsMethodSyntax = student2.Contains(new Student() { Id = 1, Name = "Kim" });
            //Output is false because it has different referance

            var std = new Student() { Id = 1, Name = "Kim" };
            student2.Add(std);
            var isExistsMethodSyntax2 = student2.Contains(std);
            //Output is true because it has same object with referance

            var comparer = new StudentComparer();

            var isExist3 = student2.Contains(new Student() { Id = 1, Name = "Kim" }, comparer);

            var querySyntaxIsExist3 = (from s in student2
                                       select s).Contains(new Student() { Id = 1, Name = "Kim" }, comparer);

            Console.ReadLine();
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (object.ReferenceEquals(x, y))
            {
                return true;
            }

            if(object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
            {
                return false;
            }
            return x.Id == y.Id && x.Name == y.Name;
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            if(Object.ReferenceEquals(obj, null))
            {
                return 0;
            }
            int idHashCode = obj.Id.GetHashCode();
            int nameHashCode = obj.Name == null ? 0 : obj.Name.GetHashCode();

            return idHashCode ^ nameHashCode;
        }
    }
}
