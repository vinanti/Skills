using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialsPoint_ConsoleApp
{
    class TypeCasting
    {
        static void Main1(string[] args)
        {
            short num1 = 10;
            short num2 = 20;
            short sum = (short)(num1 + num2);
            Console.WriteLine(sum);

            int a = 10;
            object o = a; //boxing
            int b = (int)o; //unboxing

        }
    }
}
