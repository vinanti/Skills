using System;

namespace Coding
{
    class Q0010
    {
        static void Main01()
        {
            IsMatch("ab", ".*c");
        }
        public static bool IsMatch(string s, string p)
        {
            if (s.Equals(p)) return true;
            else if (s.Length == 0 || p.Length == 0) return false;
            else if (!p.Contains('*') && !p.Contains('.')) return s.Equals(p);
            else if (p[0] != '.' && p[0] != '*' && p[1] != '*' && p[0] != s[0]) return false;

            int i = 0, j = 0;
            char currS = ' ';
            char currP = ' ';
            while (i < s.Length && j < p.Length)
            {
                if (p[j] == s[i])
                {
                    i++; j++;
                    if (i < s.Length) currS = p[i];
                    else currS = ' ';
                }
                else if (p[j] != s[i] && p[j] == '.')
                { 
                    i++; j++;
                    if (i < s.Length) currS = p[i];
                    else currS = ' ';
                }
                else if (p[j] != s[i] && p[j] == '*')
                {
                    if (currS == s[i]) { i++; }
                    else if(currP != ' ') { j++; currP = ' '; }
                    else { j++; }
                }
                else
                {
                    currP = p[j];
                    j++;
                }
            }
            if (i < s.Length) return false;
            return true;
        }
    }
}
