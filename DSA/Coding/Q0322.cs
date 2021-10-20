using System;
using System.Collections.Generic;

namespace Coding
{
    class Q0322
    {
        static void Main322()
        {
            CoinChange(new int[] { 1, 2, 5 }, 11);
        }
        public static int CoinChange(int[] coins, int amount)
        {
            List<int> list = new List<int>();
            foreach (int c in coins)
                if (amount - c > 0) list.Add(amount - c);
            int count = 1;
            while (list.Count > 0)
            {
                List<int> tempList = new List<int>(list);
                foreach (int l in tempList)
                {
                    count++;
                    foreach (int c in coins)
                    {
                        if (l - c == 0) return count;
                        else if (l - c > 0) list.Add(l - c);
                    }
                    list.Remove(l);
                }
            }
            return -1;
        }
    }
}
