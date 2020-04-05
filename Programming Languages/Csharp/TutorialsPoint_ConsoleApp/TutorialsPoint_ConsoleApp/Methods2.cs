using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialsPoint_ConsoleApp
{
    class Methods2
    {
        static void Add(int x, int y) //formal arguments
        {
            int sum = x + y;
            Console.WriteLine(sum);
        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
        static void Main1(string[] args)
        {
            int num1 = 10, num2 = 20;
            Add(num1, num2); //Actual aruments
            Add(20, 50);
        }
    }
}
