using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_ARecursionI03
{
    class ARecursionI03_DuplicateCalculation
    {
        static void Main03()
        {
           int result = Fibonacci(3);
        }
        public static int Fibonacci(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
