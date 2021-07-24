using System;

namespace myConsoleApp
{
    class Program7
    {
        static void Main7(string[] args)
        {
            //string s = null;
            int? a = null;

            int? b = a ?? 20;
            Console.WriteLine(b);

            int? c = b ?? 10;
            Console.WriteLine(b);
        }
    }
}
