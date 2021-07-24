//Buggy Code (Part 5)
using System;
using System.Collections.Generic;

namespace CSharpChallanges
{
    class Program42
    {
        static void Main42(string[] args)
        {
            PrintArray(1);
            PrintArray(3);
            PrintArray(6);
        }
        public static List<int> PrintArray(int number)
        {
            List<int> array = new List<int>();
    
            for(int counter = 1; counter <= number; counter++)
            {
                array.Add(counter);
            }
            foreach(var a in array)
                System.Console.WriteLine(a);
            return array;
        }

    }
}
