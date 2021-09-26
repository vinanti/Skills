using System;
using System.Collections.Generic;

namespace Coding_Q0771
{
    class Q0771
    {
        static void Main771()
        {
            NumJewelsInStones("aA", "aAAbbbb"); //3
        }

        //Approach #2: Hash Set
        public static int NumJewelsInStones(string jewels, string stones)
        {
            HashSet<char> jewelList = new HashSet<char>();
            foreach (char j in jewels)
                jewelList.Add(j);
            int numJewels = 0;
            foreach (char s in stones)
                if (jewelList.Contains(s))
                    numJewels++;
            return numJewels;
        }

        //Approach #1: Brute Force
        public static int NumJewelsInStones01(string jewels, string stones)
        {
            int numJewels = 0;
            foreach (char s in stones)
                if (jewels.Contains(s))
                    numJewels++;
            return numJewels;
        }
    }
}
