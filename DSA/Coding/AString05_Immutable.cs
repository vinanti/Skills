using System;

namespace Coding_AString05
{
    class AString05_Immutable
    {
        
        public static void Main05()
        {
            string s1 = "Hello World";
            //s1[5] = ',';  //throws error since string is Immutable in C#
            //Error CS0200  Property or indexer 'string.this[int]' cannot be assigned to --it is read only
            Console.WriteLine(s1);
        }
    }
}
