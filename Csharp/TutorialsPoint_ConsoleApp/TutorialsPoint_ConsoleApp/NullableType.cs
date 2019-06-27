using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialsPoint_ConsoleApp
{
    class NullableType
    {
        static void Main1(string[] args)
        {
            string s = null;
            int? a = null;
            Console.WriteLine(a);
            int? b = a ?? 20;
            Console.WriteLine(b);
            a = 10;
            b = a ?? 20;
            Console.WriteLine(b);
        }
    }
}
