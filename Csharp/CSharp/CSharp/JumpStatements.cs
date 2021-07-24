using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStatementsns
{
    class JumpStatements
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Break Statement");
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                    break;
                Console.WriteLine("i = " + i);
            }
            Console.WriteLine("Continue Statement");
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                    continue;
                Console.WriteLine("i = " + i);
            }
            Console.WriteLine("GoTo Statement");
            int x = 1;
            abc:
            Console.WriteLine(x);
            x++;
            if (x <= 5)
                goto abc;

            Console.WriteLine("return Statement");
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the SECOND number: ");
            int num2 = int.Parse(Console.ReadLine());

            if(num2 == 0)
            {
                Console.WriteLine("cANNOT DIVIDE A NUMBER BY 0");
                return;
            }

            int Result = num1 / num2;
            Console.WriteLine("Resilt is : " + Result);
        }
    }
}
