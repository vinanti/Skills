using System;

namespace LambdaExpression
{
    delegate int Del(int x);
    delegate int Del2(int x, int y);
    delegate void Del3(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Del del = x => x * x;
            int result = del(4);
            System.Console.WriteLine(result);

            Del2 del2 = (x, y) => x * y;
            int result2 = del2(4, 6);
            System.Console.WriteLine(result2);
            Del3 del3 = (x, y) => {System.Console.WriteLine(x * y);};


        }
            
    }
}