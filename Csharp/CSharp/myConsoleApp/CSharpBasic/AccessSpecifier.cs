using System;
//#define PI

namespace AccessSpecifierNameSpace
{
    class MyClass1
    {
         internal int a;
        
    }
    class Program12
    {
        static void Main5(string[] args)
        {
           MyClass1 m = new MyClass1();
            m.a = 100;
        }
            
    }
}