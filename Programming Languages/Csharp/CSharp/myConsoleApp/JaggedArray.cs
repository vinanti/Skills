using System;

namespace myConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[3] {1, 2, 3};
            arr[1] = new int[2] {10, 20};
            arr[2] = new int[4] {11, 22, 33, 44};
            foreach(int[] ar in arr)
            {
                foreach(int item in ar)
                {
                    System.Console.Write(item + "\t");
                }
                System.Console.WriteLine();
            }
        }
    }
}
