using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ReverseMethod
    {
        static void Main_ReverseMethod(string[] args)
        {
            int[] rollNum = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var mq = rollNum.Reverse().ToList();

             foreach (var item in mq)
                Console.WriteLine(item);

            var qs = (from num in rollNum
                      select num).Reverse().ToList();
            foreach (var item in qs)
                Console.WriteLine(item);

            Console.WriteLine("-----------------------------");
            List<string> names = new List<string>() { "Mark", "John", "Adam", "Umar", "Bob" };

            //Generic reverse method
            names.Reverse();

            foreach (var item in names)
                Console.WriteLine(item);
            Console.WriteLine("-----------------------------");
            //LinQ reverse method
            var reverse = names.AsEnumerable().Reverse();
            foreach (var item in reverse)
                Console.WriteLine(item);
            Console.WriteLine("-----------------------------");
            var reverse2 = names.AsQueryable().Reverse();
            foreach (var item in reverse2)
                Console.WriteLine(item);
            Console.ReadLine();
        }
    }
}
