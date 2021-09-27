using System;
using System.Collections.Generic;

namespace Coding
{
    class Q1239
    {
        static void Main1239()
        {
            IList<string> arr = new List<string>() { "cha", "r", "act", "ers" };
            MaxLength(arr);
        }
        public static int MaxLength(IList<string> arr)
        {
            int maxLength = 0;
            if (arr.Count == 0) return 0;
            if (arr.Count == 1) maxLength = arr[0].Length;
            if (arr.Count == 2) maxLength = arr[0].Length + arr[1].Length;
            
            for (int i = 0; i < arr.Count; i++)
                for (int j = i + 1; j < arr.Count; j++)
                    maxLength = Math.Max(maxLength, arr[i].Length + arr[j].Length);
            return maxLength;
        }
    }
}
