using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialsPoint_ConsoleApp
{
    class ForLoop
    {
        static void Main1(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isprime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isprime = false;
                    break;
                }
            }
            if (isprime)
                Console.WriteLine("Number is PRIME");
            else
                Console.WriteLine("Number is NOT PRIME");
            Console.WriteLine("------------------------1");
   
            for (num = 1; num <= 100; num++)
            {
                isprime = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                    Console.Write(num + "\t");
            }
            Console.WriteLine("\n------------------------2");
        }
    }
}
