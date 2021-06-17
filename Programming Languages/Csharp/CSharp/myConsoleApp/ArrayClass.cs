using System;

namespace myConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {7, 3, 5, 1, 9, 2};
            int[] arrc = new int[6];
            Array.Copy(arr, arrc, 5);
            System.Console.WriteLine(arrc[1]);
            int[,] arr2 = new int[2,3] { {1,2,3}, {11,22,33} };
            int[,,] arr3 = new int[,,] { {{1},{2}}, {{11},{22}} };
            int f = arr3.Length;
            System.Console.WriteLine(f);
            System.Console.WriteLine(arr3[0,1,0]);
            System.Console.WriteLine(Array.IndexOf(arr,9));

            System.Console.WriteLine("Reverse");
            Array.Reverse(arr);
            foreach(int a in arr)
                System.Console.WriteLine(a);

            System.Console.WriteLine("Sort");
            Array.Sort(arr);
            foreach(int a in arr)
                System.Console.WriteLine(a);

            System.Console.WriteLine("Binary Search");
            System.Console.WriteLine(Array.BinarySearch(arr,9));
            
        }
    }
}
