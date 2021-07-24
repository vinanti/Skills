//Calculate Using String Operation
using System;

namespace CSharpChallanges
{
    class Program35
    {
        static void Main35(string[] args)
        {
            Console.WriteLine(Calculate(4, 9, "+"));
            Console.WriteLine(Calculate(12, 5, "-"));
            Console.WriteLine(Calculate(6, 3, "*"));
            Console.WriteLine(Calculate(14, 3, "%"));
            Console.WriteLine(Calculate(6, 3, "/"));
        }
        public static int Calculate(int num1, int num2, string operation)
        {
            switch(operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "%":
                    return num1 % num2;
                case "/":
                    return num1 / num2;
                default:
                    break;
            }
			return 0;
        }
    }
}