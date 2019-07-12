using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialsPoint_ConsoleApp
{
    class LogicalOperators
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("AND");
            Console.WriteLine(true && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(false && false);
            Console.WriteLine("OR");
            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(false || false);
            Console.WriteLine("------------------------1");
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string valid = (username == "anadi" && password == "tp") ? "Welcome user" : "Invalid User";
            Console.WriteLine(valid);
            Console.WriteLine("------------------------2");
        }
    }
}
