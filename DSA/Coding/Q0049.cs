using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding
{
    class Q0049
    {
        static void Main49()
        {
            GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" }); //[["bat"],["nat","tan"],["ate","eat","tea"]]
        }
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
            foreach (string s in strs)
            {
                char[] chars = s.ToCharArray();
                Array.Sort(chars);

                string key = new string(chars);
                if (!groups.ContainsKey(key)) groups.Add(key, new List<string>() { s });
                else groups[key].Add(s);

            }
            List<IList<string>> result = new List<IList<string>>(groups.Values.ToList());
            return result;
        }
    }
}
