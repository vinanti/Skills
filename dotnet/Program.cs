using System;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.E);
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Tau);

            decimal d = 10.5M;
            Console.WriteLine(Math.Abs(d));

            int int1 = Int32.MaxValue;
            int int2 = Int32.MaxValue;
            long longResult;
//
            longResult = Math.BigMul(int1, int2);
            System.Console.WriteLine(longResult);
            System.Console.WriteLine(int1);
            System.Console.WriteLine(int2);
            longResult = (long)((long)int1 * (long)int2);
   
            System.Console.WriteLine(longResult);
        }
    }
}
