/*Purge and Organize
 Given an array of numbers, write a function that returns an array that...

Has all duplicate elements removed.
Is sorted from least value to greatest value.
Examples
UniqueSort([1, 2, 4, 3]) ➞ [1, 2, 3, 4]

UniqueSort([1, 4, 4, 4, 4, 4, 3, 2, 1, 2]) ➞ [1, 2, 3, 4]

UniqueSort([6, 7, 3, 2, 1]) ➞ [1, 2, 3, 6, 7]*/
using System;
using System.Linq;

namespace CSharpChallanges
{
    class Program48
    {
        static void Main48(string[] args)
        {
            Console.WriteLine("Query1");
            var answer1 = UniqueSort(new double[] { 1, 2, 4, 3 });
            foreach(double item in answer1)
                Console.WriteLine(item);

            Console.WriteLine("Query2");
            var answer2 = UniqueSort(new double[] { 1, 4, 4, 4, 4, 4, 3, 2, 1, 2 });
            foreach (double item in answer2)
                Console.WriteLine(item);

            Console.WriteLine("Query3");
            var answer3 = UniqueSort(new double[] { 6, 7, 3, 2, 1 });
            foreach (double item in answer3)
                Console.WriteLine(item);

            Console.ReadLine();
        }
        public static double[] UniqueSort(double[] arr)
        {
            return arr.Distinct().OrderBy(x => x).ToArray();
        }

    }
}
