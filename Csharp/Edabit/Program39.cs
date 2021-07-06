//Return the Last Element in an Array
using System;

namespace Edabit
{
    class Program39
    {
        static void Main39(string[] args)
        {
            Console.WriteLine(GetLastItem(new object[] {"Cat", "Dog", "Duck"}));
            Console.WriteLine(GetLastItem(new object[] {5, 6, 7}));
            Console.WriteLine(GetLastItem(new object[] {"Semiramis","Gaia","Hypatia"}));
            Console.WriteLine(GetLastItem(new object[] {-500, 0, 500}));
            Console.WriteLine(GetLastItem(new object[] {'n','m','v'}));
            Console.WriteLine(GetLastItem(new object[] {3.3, 4.4, 5.5}));
            Console.WriteLine(GetLastItem(new object[] {true,false,true}));
        }
        public static object GetLastItem(object[] arr) => arr[arr.Length-1];

    }
}
