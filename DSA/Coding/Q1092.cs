using System;

namespace Coding
{
    class Q1092
    {
        static void Main1092()
        {
            ShortestCommonSupersequence("bbbaaaba", "bbababbb"); //"bbabaaababb"
        }
        public static string ShortestCommonSupersequence(string str1, string str2)
        {
            char[] str1Arr = str1.ToCharArray();
            char[] str2Arr = str2.ToCharArray();
            int length = str1.Length > str2.Length ? str1.Length : str2.Length;
            string result = string.Empty;
            for (int i = 0; i < length; i++)
            {
                if (i < str1Arr.Length && i < str2Arr.Length)
                {
                    if (str1Arr[i] == str2Arr[i])
                    {
                        result += str1Arr[i].ToString();
                    }
                    else
                    {
                        result += str1Arr[i].ToString() + str2Arr[i].ToString();
                    }
                }
                else if (i < str1Arr.Length)
                {
                    result += str1Arr[i].ToString();
                }
                else if (i < str2Arr.Length)
                {
                    result += str2Arr[i].ToString();
                }
            }
            return result;
        }
        public static string ShortestCommonSupersequence02(string str1, string str2)
        {
            char[] str1Arr = str1.ToCharArray();
            char[] str2Arr = str2.ToCharArray();
            int length = str1.Length > str2.Length ? str1.Length : str2.Length;
            string result = string.Empty;
            for(int i = 0; i < length; i++)
            {
                if(str1Arr[i] == str2Arr[i])
                {
                    result += str1Arr[i].ToString();
                }
                else
                {
                    result += str1Arr[i].ToString() + str2Arr[i].ToString();
                }
            }
            return result;
        }
        public static string ShortestCommonSupersequence01(string str1, string str2)
        {
            string smallStr, bigStr;
            if (str1.Length >= str2.Length)
            {
                smallStr = str2; bigStr = str1;
            }
            else
            {
                smallStr = str1; bigStr = str2;
            }
            string commonStr = string.Empty;
            for (int l = smallStr.Length; l > 0; l--)
            {
                commonStr = smallStr.Substring(0, l);
                if (bigStr.EndsWith(commonStr))
                {
                    return bigStr + smallStr.Remove(0, commonStr.Length);
                }
                commonStr = smallStr.Substring(smallStr.Length - l, l);
                if (bigStr.StartsWith(commonStr))
                {
                    return smallStr + bigStr.Remove(0, commonStr.Length);
                }
            }
            return string.Empty;
        }
    }
}
