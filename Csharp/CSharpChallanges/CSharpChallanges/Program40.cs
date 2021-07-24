//Reverse an Array
using System;
using System.Linq;

namespace CSharpChallanges
{
    class Program40
    {
        static void Main40(string[] args)
        {
            
            PrintArray(Reverse(new int[] {1, 2, 3, 4}));
            PrintArray(Reverse(new int[] {9, 9, 2, 3, 4}));
            PrintArray(Reverse(new int[] {}));
        }
        public static int[] Reverse(int[] arr)
        {
            Array.Reverse(arr);
            return arr;
        } 

        public static void PrintArray(int[] arr)
        {
                System.Console.WriteLine("\nPrint");
                foreach(int a in arr)
                    System.Console.Write(a);
        }

    }
}
