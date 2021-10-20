using System;
using System.Collections.Generic;

namespace Coding
{
    class Q0300
    {
        static void Main300()
        {
            LengthOfLIS(new int[] { 0, 1, 0, 3, 2, 3 });
        }
        public static int LengthOfLIS(int[] nums)
        {
            List<List<int>> list = new List<List<int>>();
            foreach (int n in nums)
            {
                List<int> current = new List<int>() { n };
                if (!list.Contains(current)) list.Add(current);
                List<List<int>> currentList = new List<List<int>>(list);
                foreach (List<int> innerList in currentList)
                {
                    if (innerList[innerList.Count - 1] < n)
                    {
                        current = new List<int>(innerList);
                        current.Add(n);
                        if (!list.Contains(current)) list.Add(current);
                    }
                }
            }
            int length = 0;
            foreach (List<int> innerList in list)
            {
                length = Math.Max(length, innerList.Count);
            }
            return length;
        }
    }
}