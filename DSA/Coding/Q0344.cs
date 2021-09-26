using System;

namespace Coding_Q0344
{
    class Q0344
    {
        static void Main344()
        {
            ReverseString(new char[] { 'h', 'e', 'l', 'l', 'o' });
        }
        public static void ReverseString(char[] s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                char tmp = s[i];
                s[i] = s[s.Length - i - 1];
                s[s.Length - i - 1] = tmp;
            }
        }
    }
}
