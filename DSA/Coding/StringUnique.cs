using System;
using System.Collections.Generic;
namespace Coding
{
    class StringUnique
    {
        static void Main_su()
        {
            LogestUniqueCharString("abcdee");
        }
        public static int LogestUniqueCharString(string s)
        {
            HashSet<char> hashSet = new HashSet<char>();
            foreach(char c in s)
                if(!hashSet.Contains(c))
                    hashSet.Add(c);
            return hashSet.Count;
        }
    }
}
