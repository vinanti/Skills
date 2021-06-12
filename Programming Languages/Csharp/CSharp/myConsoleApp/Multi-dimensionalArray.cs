using System;

namespace myConsoleApp
{
    class Program18c
    {
        static void Main18c(string[] args)
        {
            int[,] arr = new int[3,4] {{1,2,3,4},{10,20,30,40},{11,22,33,44}};
            for (int i=0; i<arr.GetLength(0); i++)
            {
                for (int j=0; j<arr.GetLength(1); j++)
                    System.Console.Write(arr[i, j] + "\t");
                System.Console.WriteLine();
            }
        }
    }
}
