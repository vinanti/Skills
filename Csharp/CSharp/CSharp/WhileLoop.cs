using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopns
{
    class WhileLoop
    {
        static void Main1(string[] args)
        {
            bool isprime = true;
            int count = 0;
            int num = 1;
            while(count < 100)
            {
                isprime = true;
                for(int i=2; i<=Math.Sqrt(num); i++)
                {
                    if (num % i ==0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                    Console.Write(num + "\t");
                    count++;
                }
                num++;
            }
            Console.WriteLine();
            Console.WriteLine("------------------------1");
            int num1 = int.Parse(Console.ReadLine());
            int temp = num1;
            int digit = 0;
            while (temp != 0)
            {
                digit++;
                temp = temp / 10;
            }
            Console.WriteLine("{0} is {1} digit number.", num1, digit);
        }
    }
}
