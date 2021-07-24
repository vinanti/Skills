using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByParamMethodns
{
    class CallByParamMethod
    {
        static int Add(int num1, int num2, params int[] list)
        {
            int sum = num1 + num2;
            foreach (int item in list)
            {
                sum += item;
            }
            return sum;
        }
        static void Main1(string[] arg)
        {
            Console.WriteLine(Add(10, 20, 30, 40, 50));
        }
    }
}
