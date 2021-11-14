using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Q0256
    {
        static void Main256()
        {
            MinCost(new int[][] { new int[] { 17, 2, 17 }, new int[] { 16, 16, 5 }, new int[] { 14, 3, 19 } });
        }
        public static int MinCost(int[][] costs)
        {
            List<List<int[]>> bucket = new List<List<int[]>>();
            for (int i = 0; i < costs[0].Length; i++)
                bucket.Add(new List<int[]>() { new int[] { 0, i } });
            for (int i = 1; i < costs.Length; i++)
            {
                List<List<int[]>> dummyBucket = new List<List<int[]>>(bucket);
                bucket.Clear();
                foreach (List<int[]> dummy in dummyBucket)
                {
                    int[] temp = dummy[dummy.Count - 1];
                    for (int j = 0; j < 3; j++)
                    {
                        if (temp[1] != j)
                        {
                            List<int[]> templist = new List<int[]>(dummy);
                            templist.Add(new int[] { i, j });
                            bucket.Add(templist);
                        }
                    }
                }
            }
            int minCost = int.MaxValue;
            foreach (List<int[]> list in bucket)
            {
                int cost = 0;
                foreach (int[] c in list)
                {
                    cost += costs[c[0]][c[1]];
                }
                minCost = Math.Min(minCost, cost);
            }
            return minCost;
        }
    }
}
