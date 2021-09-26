using System;

namespace Coding_ARecursionI02
{
    class ARecursionI02_ReverseString
    {
        class Solution
        {
            static void Main03()
            {
                ReverseString(new char[] { 'a', 'b', 'c' });
            }
            public static void ReverseString(char[] s)
            {
                Helper(0, s.Length - 1, s);
            }

            private static void Helper(int start, int end, char[] s)
            {
                if (start >= end)
                {
                    return;
                }
                // swap between the first and the last elements.
                char tmp = s[start];
                s[start] = s[end];
                s[end] = tmp;

                Helper(start + 1, end - 1, s);
            }
        }
    }
}
