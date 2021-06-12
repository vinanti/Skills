using System;

namespace myConsoleApp
{
    class Program18a
    {
        static void Main18a(string[] args)
        {
            int[] arr = new int[] {7, 3, 5, 1, 9, 2};
            int temp;
            for (int i=0; i<arr.Length; i++)
            {
                for (int j=0; j<arr.Length-1; j++)
                {
                    if(arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            foreach(int item in arr)
                System.Console.WriteLine(item);
        }
    }
}
