using System;

namespace myConsoleApp
{
    class Program8c
    {
        static void Main8c(string[] args)
        {
            Console.WriteLine(true && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(false && false);
            
            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(false || false);

            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string valid = (username == "vinanti" && password == "123") ? "Welcome user" : "Invalid user";
            Console.WriteLine(valid);
        }
    }
}
