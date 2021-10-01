using System;

namespace Coding_Q0186
{
    public class Q0186
    {
        static void Main()
        {
            ReverseWords(new char[] { 't', 'h', 'e', ' ', 's', 'k', 'y', ' ', 'i', 's', ' ', 'b', 'l', 'u', 'e' });
        }
        public static void ReverseWords(char[] s)
        {
            string str = new string(s);
            string[] strArray = str.Split();
            str = string.Empty;
            for (int i = strArray.Length - 1; i >= 0; i--)
                str += strArray[i] + " ";
            int j = 0;
            foreach (char c in str.Trim())
            {
                s[j] = c;
                j++;
            }
        }
    }
}
