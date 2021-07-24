using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopsns
{
    class Loops
    {
        static void Main1(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------------1");
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                sum = sum + i;
            }
            Console.WriteLine("------------------------");
            Console.WriteLine(sum);
            Console.WriteLine("------------------------2");
            int sum1 = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    sum1 = sum1 + i;
                }
            }
            Console.WriteLine("------------------------");
            Console.WriteLine(sum1);
            Console.WriteLine("------------------------3");
        }
    }
}