using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitioningOperationTakeWhilens
{
    class PartitioningOperationTakeWhile
    {
        static void Main1(string[] args)
        {
            int[] numbers=new int[] { 1, 2, 6, 7, 8, 9, 10, 3, 4, 5 };

            //Ex. fetch all records untill the no is less than 7
            var methodSyntax = numbers.TakeWhile((x, i) => i < 5).ToList();

            foreach (var item in methodSyntax)
                Console.WriteLine(item);
            Console.WriteLine("--------------------------------------------------");

            var querySyntax = (from n in numbers
                               select n).TakeWhile(n => n < 7).ToList();

            foreach (var item in querySyntax)
                Console.WriteLine(item);

            Console.WriteLine("--------------------------------------------------");
            List<string> names = new List<string>() { "Kim", "John", "Mark", "Ada", "Nitish" };

            //Ex. Length of name is greater than index
            var ms1 = names.TakeWhile((name, index) => name.Length > index).ToList();

            foreach (var item in ms1)
                Console.WriteLine(item);

            Console.WriteLine("--------------------------------------------------");


        }
    }
}
