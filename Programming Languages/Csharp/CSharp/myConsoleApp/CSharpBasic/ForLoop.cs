using System;

namespace myConsoleApp
{
    class Program14
    {
        static void Main14(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                sum = sum + i;
            }
            Console.WriteLine("------------------------");
            Console.WriteLine(sum);
/*
            for (; ; )
            {
                Console.WriteLine(1);
            }
*/
        }
    }
}
