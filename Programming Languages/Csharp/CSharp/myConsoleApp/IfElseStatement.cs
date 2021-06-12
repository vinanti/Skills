using System;

namespace myConsoleApp
{
    class Program11
    {
        static void Main11(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
    }
}
