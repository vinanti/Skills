using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Q0557
{
    class Q0557
    {
        static void Main557()
        {
            string s = "Let's take LeetCode contest";
            ReverseWords(s);
        }
        public static string ReverseWords(string s)
        {
            if (s.Length < 1) return s;
            string[] slist = s.Split();
            s = string.Empty;
            foreach (string l in slist)
            {
                for (int i = l.Length - 1; i >= 0; i--)
                    s += l[i];
                s += " ";
            }
            return s.Trim();
        }
    }
}
