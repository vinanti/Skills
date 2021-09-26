using System;
using System.Linq;

namespace Coding_Q0014
{
    class Q0014
    {
        static void Main14()
        {
            LongestCommonPrefix(new string[] { "flower", "flow", "flight" }); //fl
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            int minLength = strs.Min(y => y.Length);
            string shortest = strs.FirstOrDefault(x => x.Length == minLength);
            string shorts = shortest;
            bool b = false;
            for (int j = shortest.Length; j > 0; j--)
            {
                if (!b)
                {
                    shorts = shortest.Substring(0, j);
                    for (int i = 0; i < strs.Length; i++)
                    {
                        if (strs[i].Substring(0, j) == shorts)
                            b = true;
                        else
                        {
                            b = false;
                            break;
                        }
                    }
                }
            }
            if (!b) shorts = "";
            return shorts;
        }
    }
}
