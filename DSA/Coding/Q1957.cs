using System;

namespace Coding
{
    class Q1957
    {
        static void Main1957()
        {
            MakeFancyString("aaabaaaa");
        }
        public static string MakeFancyString(string s)
        {
            if (s.Length < 3) return s;
            char[] sChar = s.ToCharArray();
            char current = sChar[0];
            string result = sChar[0].ToString();
            bool flag = false;
            for (int i = 1; i < s.Length; i++)
            {
                if (current != sChar[i])
                {
                    current = sChar[i];
                    flag = false;
                    result += sChar[i].ToString();
                }
                else if (current == sChar[i] && !flag)
                {
                    result += sChar[i].ToString();
                    flag = true;
                }
            }
            return result;
        }
    }
}
