using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3ns
{
    class Method3
    {
        static int Add(int x, int y) 
        {
            int sum = x + y;
            return sum;
        }
        static void Main1(string[] args)
        {
            int num1 = 10, num2 = 20;
            int result = Add(num1, num2); 
            Console.WriteLine(result);
        }
    }
}
