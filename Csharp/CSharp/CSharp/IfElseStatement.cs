using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseStatementns
{
    class IfElseStatement
    {
        static void Main1(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("It is an even number");
            }
            else
            {
                Console.WriteLine("It is an odd number");
            }
            Console.WriteLine("------------------------1");

            Console.WriteLine("Enter your percentage: ");
            float percent = float.Parse(Console.ReadLine());

            if (percent >= 80)
                Console.WriteLine("Grade A");
            else if (percent >= 60)
                Console.WriteLine("Grade B");
            else if (percent >= 40)
                Console.WriteLine("Grade C");
            else
                Console.WriteLine("Grade D");
            Console.WriteLine("------------------------2");

            Console.WriteLine("Enter your percentage: ");
            float percent1 = float.Parse(Console.ReadLine());

            if (percent1 >= 80)
                Console.WriteLine("Grade A");
            if (percent1 >= 60)
                Console.WriteLine("Grade B");
            if (percent1 >= 40)
                Console.WriteLine("Grade C");
            else
                Console.WriteLine("Grade D");
            Console.WriteLine("------------------------3");
        }
    }
}
