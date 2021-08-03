using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitioningOperationTakens
{
    class PartitioningOperationTake
    {
        static void Main1(string[] args)
        {
            int[] numbers=new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.Take(5).ToList();

            foreach (var item in methodSyntax)
                Console.WriteLine(item);
            Console.WriteLine("--------------------------------------------------");

            var querySyntax = (from n in numbers
                               select n).Take(5).ToList();

            foreach (var item in querySyntax)
                Console.WriteLine(item);

            Console.WriteLine("--------------------------------------------------");

            //Get 1st 3 records whose value is greater than 3

            var methodSyntax2 = numbers.Where(n => n > 3).Take(5).ToList();
            foreach (var item in methodSyntax2)
                Console.WriteLine(item);
            Console.WriteLine("--------------------------------------------------");

            var querySyntax2 = (from n in numbers
                                where n > 3
                               select n).Take(5).ToList();

            foreach (var item in querySyntax)
                Console.WriteLine(item);

            Console.WriteLine("--------------------------------------------------");
            //if swap methods where & take

            var methodSyntax3 = numbers.Take(5).Where(n => n > 3).ToList();
            foreach (var item in methodSyntax3)
                Console.WriteLine(item);
            Console.WriteLine("--------------------------------------------------");

        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
