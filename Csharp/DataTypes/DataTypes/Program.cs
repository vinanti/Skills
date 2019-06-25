using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            const int a = 10;
            int b = 10;
            string s = "Tutorials Point";

            string name = "John";
            int age = 30;

            Console.WriteLine("User name is " + name);
            Console.WriteLine("User age is " + age);

            Console.WriteLine("User name is " + name + "\nUser age is " + age);

            Console.WriteLine("User name is {0} \nUser age is {1}", name, age);
        }
    }
}
