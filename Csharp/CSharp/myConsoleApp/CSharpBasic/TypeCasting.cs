using System;

namespace myConsoleApp
{
    class Program3
    {
        static void Main3(string[] args)
        {
            short num1 = 10;
            short num2 = 20;
            short sum = (short)(num1 + num2);
            Console.Write(sum);

            int a = 10;
            object o = a; //Boxing
            int b = (int)o;  //Unboxing
        }
    }
}
