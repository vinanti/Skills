

/*Valid Palindrome*/

using System;
namespace Coding_Q0125
{
    class Solution
    {
        static void Main125()
        {
            Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
        }
        public static bool IsPalindrome(string s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                while (i < j && !char.IsLetterOrDigit(s[i]))
                {
                    i++;
                }
                while (i < j && !char.IsLetterOrDigit(s[j]))
                {
                    j--;
                }
                if (s[i].ToString().ToLower() != s[j].ToString().ToLower())
                    return false;
            }
            return true;
        }
    }

    //class Q0125
    //{
    //    static void Main125()
    //    {
    //        Console.WriteLine(IsValidPalindrom("A man, a plan, a canal: Panama"));
    //    }
    //    public static bool IsValidPalindrom(string s)
    //    {
    //        char[] cArray = s.ToCharArray();
    //        int j = s.Length-1;
    //        s = string.Empty;
    //        string s2 = string.Empty;
    //        for(int i = 0; i<cArray.Length; i++, j--)
    //        {
    //            if (char.IsLetterOrDigit(cArray[i])) s += cArray[i];
    //            if (char.IsLetterOrDigit(cArray[j])) s2 += cArray[j];
    //        }
    //        return s.ToLower() == s2.ToLower();
    //    }
    //}
}



