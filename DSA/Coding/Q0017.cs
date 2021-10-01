using System;
using System.Collections.Generic;

namespace Coding_Q0017
{
    public class Q0017
    {
        static void Main17()
        {
            LetterCombinations("23");
        }
        public static IList<string> LetterCombinations(string digits)
        {
            if (digits.Length == 0) return new List<string>() { };

            Dictionary<char, char[]> master = new Dictionary<char, char[]>();
            master.Add('1', new char[] { });
            master.Add('2', new char[] { 'a', 'b', 'c' });
            master.Add('3', new char[] { 'd', 'e', 'f' });
            master.Add('4', new char[] { 'g', 'h', 'i' });
            master.Add('5', new char[] { 'j', 'k', 'l' });
            master.Add('6', new char[] { 'm', 'n', 'o' });
            master.Add('7', new char[] { 'p', 'q', 'r', 's' });
            master.Add('8', new char[] { 't', 'u', 'v' });
            master.Add('9', new char[] { 'w', 'x', 'y', 'z' });
            master.Add('*', new char[] { });
            master.Add('0', new char[] { });
            master.Add('#', new char[] { });

            List<string> list = new List<string>();

            foreach (char d in digits)
            {
                if (list.Count == 0)
                {
                    foreach (char c in master[d])
                        list.Add(c.ToString());
                }
                else
                {
                    List<string> temp = new List<string>();
                    foreach (string s in list)
                        temp.Add(s);
                    foreach (char c in master[d])
                    {
                        for (int i = 0; i < temp.Count; i++)
                        {
                            list.Add(temp[i] + c.ToString());
                            list.Remove(temp[i]);
                        }
                    }

                }
            }
            return list;
        }
    }
}
