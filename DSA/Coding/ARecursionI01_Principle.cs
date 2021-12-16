using System;

namespace Coding_ARecursionI01
{
    class ARecursionI01_Principle
    {
        static void Main()
        {
            PrintReverse(new char[] { 'a', 'b', 'c' });
        }
        private static void PrintReverse(char[] str)
        {
            Helper(0, str);
        }

        private static void Helper(int index, char[] str)
        {
            if (str == null || index >= str.Length)
            {
                return;
            }
            Helper(index + 1, str);
            Console.WriteLine(str[index]);
        }
    }
}
