using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialsPoint_ConsoleApp
{
    class WhileLoop
    {
        static void Main(string[] args)
        {
            for (int num = 1; num <= 100; num++)
            {
                bool isprime = true;
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
            }
        }
        

    }
}
