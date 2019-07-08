using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialsPoint_ConsoleApp
{
    class NullableType
    {
        static void Main(string[] args)
        {
            string s = null;
            int? a = null;
            Console.WriteLine("s:" + s + "\na:" + a);

            int? a1 = 10;
            int? b1 = a1 ?? 20;
            Console.WriteLine(b1);

            int? a2 = null;
            int? b2 = a2 ?? 20;
            Console.WriteLine(b2);
        }
    }
}
