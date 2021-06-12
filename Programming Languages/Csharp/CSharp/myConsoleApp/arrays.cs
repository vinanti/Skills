using System;

namespace myConsoleApp
{
    class Program18
    {
        static void Main18(string[] args)
        {
            int[] arr = new int[] {7, 3, 5, 1, 9, 2};
            System.Console.WriteLine(arr[0]);
            for (int i=0; i<6; i++)
                System.Console.WriteLine(arr[i]);

            foreach(int item in arr)
                System.Console.WriteLine(item);
        }
    }
}
