using System;

namespace myConsoleApp
{
    class Program2
    {
        static void Main2(string[] args)
        {
            const int c =10;
            int a = 10;
            string s = "Tutorials Pont";

            Console.WriteLine(c);
            Console.WriteLine(a);
            Console.WriteLine(s);

            string  name = "John";
            int age = 30;
            Console.WriteLine("User Name is " + name + "\nUser age is " + age);
            Console.WriteLine("User Name is {0} \nUser age is {1}", name, age);

            Console.WriteLine("Enter User Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter User Age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("User Name is {0} \nUser age is {1}", name, age);
        }
    }
}
