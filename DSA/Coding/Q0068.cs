using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Q0068
    {
        static void Main1()
        {
            FullJustify(new string[] { "Listen", "to", "many,", "speak", "to", "a", "few." }, 6);
        }
        public static IList<string> FullJustify(string[] words, int maxWidth)
        {
            List<string> list = new List<string>();
            string temp = string.Empty;
            foreach (string w in words)
            {
                if (temp.Length + w.Length >= maxWidth)
                {
                    list.Add(temp);
                    temp = w;
                }
                else
                {
                    if (temp.Length > 0) temp += " " + w;
                    else temp = w;
                }
            }
            if (temp.Length > 0) list.Add(temp);
            for (int i = 0; i < list.Count - 1; i++)
            {
                int space = maxWidth - list[i].Length;
                string[] wordArray = list[i].Split(" ");
                list[i] = wordArray[0];
                int addSpaceCount = wordArray.Length - 1;
                int addSpace = 0;
                if (addSpaceCount > 0)
                    addSpace = space / addSpaceCount;
                for (int j = 1; j < wordArray.Length; j++)
                {
                    int k = addSpace;
                    if (addSpace * addSpaceCount < space)
                    {
                        k++;
                        space -= k;
                    }
                    while (k > 0)
                    {
                        list[i] += " ";
                        k--;
                    }
                    list[i] += " " + wordArray[j];
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Length < maxWidth)
                {
                    int k = maxWidth - list[i].Length;
                    while (k > 0)
                    {
                        list[i] += " ";
                        k--;
                    }
                }
            }
            return list;
        }
    }
}
