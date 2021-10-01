using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingQuestion_Q1239
{
    public class Q1239
    {
        static void Main()
        {
            MaxLength(new List<string> { "cha", "r", "act", "ers" });
        }
        public static int MaxLength(IList<string> arr)
        {
            string result = string.Empty;
            List<string> list = arr.OrderByDescending(x => x.Length).ToList();
            
            foreach (string str in arr)
            {
                if (IsUniqueToConcate(str, result))
                    result += str;
            }
            return result.Length;
        }
        public static bool IsUniqueToConcate(string str1, string str2)
        {
            HashSet<char> hashSet = new HashSet<char>();
            foreach (char c in str1)
                if (hashSet.Contains(c)) return false;
                else hashSet.Add(c);
            foreach (char c in str2)
                if (hashSet.Contains(c)) return false;
                else hashSet.Add(c);
            return true;
        }
    }
}
