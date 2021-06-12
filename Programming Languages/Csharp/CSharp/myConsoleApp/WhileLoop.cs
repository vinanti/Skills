using System;

namespace myConsoleApp
{
    class Program15
    {
        static void Main15(string[] args)
        {
           int num = int.Parse(Console.ReadLine());
           int temp = num;
           int digits = 0;
           while (temp != 0)
           {
               digits++;
               temp = temp / 10;
           }
           Console.WriteLine("{0} is {1} digit numbers.", num, digits);
        }
    }
}
