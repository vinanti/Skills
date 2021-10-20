using System;

namespace Coding
{
    
    public class Q1156
    {
        static void Main1156()
        {
            MaxRepOpt1("aaabaaa");
        }
        public static int MaxRepOpt1(string text)
        {
            int max = 0, length = text.Length;
            while (length > 0)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text.Length >= length + i)
                    {
                        string subText = text.Substring(i, length);
                        max = Math.Max(max, GetMaxRepeatedCharacter(subText.Substring(0, length)));
                    }

                }
                length--;
            }
            return max;
        }
        public static int GetMaxRepeatedCharacter(string str)
        {
            char[] charArray = str.ToCharArray();
            int max = 0, curr = 0; char currChar = ' ';
            for (int j = -1; j < charArray.Length; j++)
            {
                for (int i = 0; i < charArray.Length; i++)
                {
                    if (i != j)
                    {
                        if (currChar == charArray[i]) curr++;
                        else
                        {
                            max = Math.Max(max, curr);
                            currChar = charArray[i];
                            curr = 0;
                        }
                    }
                }
            }

            return max;
        }
    }
}
