﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialsPoint_ConsoleApp
{
    class ComparisionOperators
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Comparision Operators");
            int a = 50, b = 20;
            Console.WriteLine(a > b); //true
            Console.WriteLine(a < b); //false
            Console.WriteLine(a >= b); //true
            Console.WriteLine(a <= b); //false
            Console.WriteLine(a == b); //false
            Console.WriteLine(a != b); //true
            Console.WriteLine("------------------------1");
            int num = 46;
            string s = num % 2 == 0 ? "Even" : "Odd";
            Console.WriteLine(s);
            Console.WriteLine("------------------------2");
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
            Console.WriteLine("------------------------3");
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string valid = (username == "anadi" && password == "tp") ? "Welcome user" : "Invalid User";
            Console.WriteLine(valid);
            Console.WriteLine("------------------------4");
        }
    }
}
