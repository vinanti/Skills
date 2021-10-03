using System;
using System.Linq;
namespace Coding_Q0005
{
    class Q0005
    {
        static void Main5()
        {
            LongestPalindrome("babad");
        }
        public static string LongestPalindrome(string s)
        {
            int length = s.Length;
            while (length > 0)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s.Length - i < length) break;
                    string str = s.Substring(i, length);
                    if (IsPalindrome(str)) return str;
                }
                length--;
            }
            return string.Empty;
        }
        public static bool IsPalindrome(string s)
        {
            int j = s.Length - 1, i = 0;
            while(i<j)
            {
                if (s[i] != s[j]) return false;
                i++; j--;
            }
            return true;
        }
    }
}
