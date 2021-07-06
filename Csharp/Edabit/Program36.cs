//Return the First Element in an Array
using System;

namespace Edabit
{
    class Program36
    {
        static void Main36(string[] args)
        {
            Console.WriteLine(GetFirstValue(new object[] {5, 6, 7}));
            Console.WriteLine(GetFirstValue(new object[] {"Semiramis","Gaia","Hypatia"}));
            Console.WriteLine(GetFirstValue(new object[] {-500, 0, 500}));
            Console.WriteLine(GetFirstValue(new object[] {'n','m','v'}));
            Console.WriteLine(GetFirstValue(new object[] {3.3, 4.4, 5.5}));
            Console.WriteLine(GetFirstValue(new object[] {true,false,true}));
        }
        public static object GetFirstValue(object[] arr) => arr[0];

    }
}
