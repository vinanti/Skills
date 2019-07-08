﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialsPoint_ConsoleApp
{
    class DataTypes
    {
        static void Main1(string[] args)
        {
            
            const int constant = 10;
            int a = 10; //Value Type
            string s = "Tutorials Point"; //Reference Type
            Console.WriteLine(constant + " " + a + " " + s);

            string name = "John";
            int age = 30;

            Console.WriteLine("User name is " + name);
            Console.WriteLine("User age is " + age);
            Console.WriteLine("User name is " + name + " User age is " + age);
            Console.WriteLine("User name is " + name + "\nUser age is " + age);

            Console.WriteLine("User name is {0} \nUser age is {1}", name, age);

            Console.WriteLine("Enter User Name:");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter age:");
            int age1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("User name is {0} \nUser age is {1}", name1, age1);

        }
    }
}
