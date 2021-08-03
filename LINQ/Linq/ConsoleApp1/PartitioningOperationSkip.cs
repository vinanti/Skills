using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitioningOperationSkipns
{
    class PartitioningOperationSkip
    {
        static void Main1(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 6, 7, 8, 9, 10, 3, 4, 5 };

            //Ex. fetch all records untill the no is less than 7
            var methodSyntax = numbers.Skip(3).ToList();

            foreach (var item in methodSyntax)
                Console.WriteLine(item);
            Console.WriteLine("--------------------------------------------------");

            var querySyntax = (from n in numbers
                               select n).Skip(8).ToList();

            foreach (var item in querySyntax)
                Console.WriteLine(item);

            Console.WriteLine("--------------------------------------------------");
            List<string> names = new List<string>() { "Kim", "John", "Mark", "Ada", "Nitish" };

            //Ex. Length of name is greater than index
            var ms1 = names.Skip(1).ToList();

            foreach (var item in ms1)
                Console.WriteLine(item);

            Console.WriteLine("--------------------------------------------------");

            var qs1 = (from n in names
                       select n).Skip(2).ToList();
            foreach (var item in qs1)
                Console.WriteLine(item);

        }
    }
}
