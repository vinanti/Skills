using System;

namespace myConsoleApp
{
    class Program17
    {
        static void Main17(string[] args)
        {
           for (int i=1; i<=10; i++)
           {
                if(i == 5)
                    break;
                Console.WriteLine("i = " + i);
           }

           for (int i=1; i<=10; i++)
           {
                if(i == 5 || i == 7)
                    continue;
                Console.WriteLine("i = " + i);
           }

           int j = 1;
           abc:
            Console.WriteLine(j);
            j++;
            if(j <= 10)
                goto abc;

            Console.WriteLine("Enter no:");
            int num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("Conn't divide by zero.");
                return;
            }
            
            int result = 100 / num;
            Console.WriteLine("Result:" + result);            
        }
    }
}
