using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Q01209
    {
        static void Main1209()
        {
            RemoveDuplicates("yfttttfbbbbnnnnffbgffffgbbbbgssssgthyyyy", 4);
        }
        public static string RemoveDuplicates(string s, int k)
        {
            int i = 0;
            while (i < s.Length)
            {
                string left = string.Empty;
                string right = string.Empty;
                if (i < s.Length)
                    left = s.Substring(0, i);
                if (s.Length - i <= s.Length)
                    right = s.Substring(i, s.Length - i);
                if (i + k <= s.Length && EqualLetters(s.Substring(i, k)))
                {
                    right = right.Substring(k, right.Length - k);
                    s = left + right;
                    i = 0;
                }
                else i++;
            }
            return s;
        }
        public static bool EqualLetters(string s)
        {
            char common = s[0];
            foreach (char c in s)
                if (c != common) return false;
            return true;
        }
    }
}
