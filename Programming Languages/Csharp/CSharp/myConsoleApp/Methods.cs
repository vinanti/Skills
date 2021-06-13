using System;

namespace myConsoleApp
{
    class Programm
    {
        static void SampleMethod()
        {
            System.Console.WriteLine("This is sample method");
        }

        static void Add(int x, int y) //formal aruments
        {
            int sum = x + y;
            System.Console.WriteLine( sum );
        }
        static int Add2(int x, int y) //formal aruments
        {
            int sum = x + y;
            return sum;
        }
        static void Mainm(string[] args)
        {
            System.Console.WriteLine("Start");
            SampleMethod();
            System.Console.WriteLine("End");

            int num1 = 10, num2 = 20;
            Add(num1, num2); //actual argument
            Add(20, 50);

            int result = Add2(num1, num2);
            System.Console.WriteLine(result);
        }
    }
}
