using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialsPoint_ConsoleApp
{
    class CallByReferenceMethod
    {
        static void SampleMethod(ref int x)
        {
            Console.WriteLine("Initial value of formal parameter: " + x);
            x = 100;
            Console.WriteLine("Final value of formal parameter: " + x);
        }
        static void Main1(string[] arg)
        {
            int a = 10;
            Console.WriteLine("Initial value of actual parameter: " + a);
            SampleMethod(ref a);
            Console.WriteLine("Final value of actual parameter: " + a);
        }
    }
}
