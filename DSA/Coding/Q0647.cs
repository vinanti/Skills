using System;
using System.Linq;

namespace Coding
{
    class Q0647
    {
        static void Main647()
        {
            CountSubstrings("aaa");
        }

        //Approach 1: Recurssion Palendrap check method
        public static int CountSubstrings(string s)
        {
            int count = s.Length;
            if (s.Length <= 1) return count;
            for (int l = 2; l <= s.Length; l++)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (l <= s.Length - i)
                    {
                        string sub = s.Substring(i, l);
                        if (IsPalindrom(sub)) count++;
                    }
                }
            }
            return count;
        }
        public static bool IsPalindrom(string str)
        {
            char[] charStr = str.ToCharArray();
            int i = 0, j = str.Length - 1;
            while (i < j)
            {
                if (charStr[i] != charStr[j]) return false;
                i++; j--;
            }
            return true;
        }

        //Approach 1: LinQ methods
        public static int CountSubstrings01(string s)
        {
            int count = s.Length;
            if (s.Length <= 1) return count;
            for (int l = 2; l <= s.Length; l++)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (l <= s.Length - i)
                    {
                        string sub = s.Substring(i, l);
                        if (sub.Equals(new string(sub.Reverse().ToArray()))) count++;
                    }
                }
            }
            return count;
        }
    }
}
