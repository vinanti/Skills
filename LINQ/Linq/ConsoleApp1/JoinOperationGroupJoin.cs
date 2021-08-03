using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinOperationGroupJoinns
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int CategoryId { get; set; }
    }
    class Category
    {
        public int Id { get; set; }
        public String Name { get; set; }
    }
    class JoinOperationGroupJoin
    {
        static void Main0(string[] args)
        {
            var students = new List<Student>()
            {
                new Student(){Id = 1, Name = "Maria", CategoryId = 1},
                new Student(){Id = 2, Name = "Amelia", CategoryId = 1},
                new Student(){Id = 3, Name = "Rebecca", CategoryId = 2},
                new Student(){Id = 4, Name = "Una", CategoryId = 2},
                new Student(){Id = 5, Name = "Victoria", CategoryId = 3},
            };

            var categories = new List<Category>()
            {
                new Category(){Id = 1, Name = "Monitor"},
                new Category(){Id = 2, Name = "Discipline"},
                new Category(){Id = 3, Name = "Nothing"},
            };

            var ms = categories.GroupJoin(students, cat => cat.Id, std => std.CategoryId,
                (cat, std) => new { cat, std });

            foreach(var item in ms)
            {
                Console.WriteLine(item.cat.Name + "==>");
                foreach(var c in item.std)
                {
                    Console.WriteLine(c.Name);
                }
            }
            Console.WriteLine("====================================");
            var qs = (from c in categories
                      join std in students on c.Id equals std.CategoryId into stdGroups
                      select new { c, stdGroups });

            foreach (var item in qs)
            {
                Console.WriteLine(item.c.Name + "==>");
                foreach (var c in item.stdGroups)
                {
                    Console.WriteLine(c.Name);
                }
            }
            Console.WriteLine("====================================");

            IList<Student> studentList = new List<Student>() {
                new Student() { Id = 1, Name = "John", Age = 18 } ,
                new Student() { Id = 2, Name = "Steve",  Age = 21 } ,
                new Student() { Id = 3, Name = "Bill",  Age = 18 } ,
                new Student() { Id = 4, Name = "Ram" , Age = 20 } ,
                new Student() { Id = 5, Name = "Abram" , Age = 21 }
            };

            var groupedResult = studentList.GroupBy(s => s.Age);

            //iterate each group        
            foreach (var ageGroup in groupedResult)
            {
                Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 

                foreach (Student s in ageGroup) // Each group has inner collection
                    Console.WriteLine("Student Name: {0}", s.Name);
            }
                Console.WriteLine("====================================");
                var lookupResult = studentList.ToLookup(s => s.Age);

                foreach (var group in lookupResult)
                {
                    Console.WriteLine("Age Group: {0}", group.Key);  //Each group has a key 

                    foreach (Student s in group)  //Each group has a inner collection  
                        Console.WriteLine("Student Name: {0}", s.Name);
                }


                Console.ReadLine();
            

        }
    }
}
