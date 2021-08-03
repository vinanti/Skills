using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PartitioningOperationSkipWhile
    {
        static void Main1(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 6, 7, 8, 9, 10, 3, 4, 5 };

            //Ex. fetch all records untill the no is less than 7
            var methodSyntax = numbers.SkipWhile(n => n < 6).ToList();

            foreach (var item in methodSyntax)
                Console.WriteLine(item);
            Console.WriteLine("--------------------------------------------------");

            var querySyntax = (from n in numbers
                               select n).SkipWhile(n => n < 6).ToList();

            foreach (var item in querySyntax)
                Console.WriteLine(item);

            Console.WriteLine("--------------------------------------------------");
            List<string> names = new List<string>() { "Kim", "John", "Ma", "Adam", "Nitish" };

            var ms1 = names.SkipWhile(x => x.Length < 4).ToList();

            foreach (var item in ms1)
                Console.WriteLine(item);

            Console.WriteLine("--------------------------------------------------");

            var qs1 = (from n in names
                       select n).SkipWhile(x => x.Length < 4).ToList();
            foreach (var item in qs1)
                Console.WriteLine(item);
            Console.WriteLine("--------------------------------------------------");
            
            var ms2 = names.SkipWhile((x, i) => x.Length > i).ToList();

            foreach (var item in ms2)
                Console.WriteLine(item);

            Console.WriteLine("--------------------------------------------------");

            var qs2 = (from n in names
                       select n).SkipWhile((x, i) => x.Length > i).ToList();
            foreach (var item in qs2)
                Console.WriteLine(item);

        }
    }
}
