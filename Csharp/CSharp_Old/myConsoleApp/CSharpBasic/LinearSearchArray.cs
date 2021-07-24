using System;

namespace myConsoleApp
{
    class Program18b
    {
        static void Main18b(string[] args)
        {
            int[] arr = new int[] {7, 3, 5, 1, 9, 2};
            System.Console.WriteLine("Enter:");
            int num = int.Parse(System.Console.ReadLine());
            bool found = false;
            for (int i=0; i<arr.Length; i++)
            {
                if(arr[i] == num)
                {
                    found = true;
                    break;
                }
            }
            if(found)
                System.Console.WriteLine("Element found!");
            else
                System.Console.WriteLine("Element not found!");
        }
    }
}
