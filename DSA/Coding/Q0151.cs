﻿using System;

namespace Coding_Q0151
{
    class Q0151
    {
        static void Main151()
        {
            ReverseWords("  Bob    Loves  Alice   "); //"blue is sky the"
        }
        public static string ReverseWords(string s)
        {
            string[] strArray = s.Split();
            s = string.Empty;
            for (int i = strArray.Length - 1; i >= 0; i--)
                if (strArray[i].Trim() != "")
                    s += strArray[i].Trim() + " ";
            return s.Trim();
        }
    }
}
