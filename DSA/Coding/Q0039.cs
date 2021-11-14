using System;
using System.Collections.Generic;
using System.Linq;
namespace Coding
{
    class Q0039
    {
        static void Main01()
        {
            CombinationSum(new int[] { 2, 3, 6, 7 }, 7);
        }
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<List<int>> result = new List<List<int>>();
            HashSet<int> unique = new HashSet<int>();
            foreach (int c in candidates)
                if (!unique.Contains(c))
                {
                    unique.Add(c);
                    if (c <= target)
                        result.Add(new List<int>() { c });
                }
            bool appended = true;
            while (appended)
            {
                List<List<int>> dummyResult = new List<List<int>>(result);
                appended = false;
                foreach (List<int> d in dummyResult)
                {
                    foreach (int u in unique)
                    {
                        if (d.Sum() + u <= target)
                        {
                            List<int> temp = new List<int>(d);
                            temp.Add(u);
                            temp = temp.OrderBy(x => x).ToList();
                            if(!ResultContains(result, temp)) 
                                result.Add(temp);
                            result.Remove(d);
                            appended = true;
                        }
                    }
                }
            }

            List<IList<int>> finalResult = new List<IList<int>>();
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i].Sum() == target) finalResult.Add(result[i]);
            }
            return finalResult;
        }

        public static bool ResultContains(List<List<int>> result, List<int> temp)
        {
            foreach(List<int> r in result)
            {
                if (r.Count == temp.Count)
                {
                    bool contains = true;
                    for (int i = 0; i < r.Count; i++)
                        if (r[i] != temp[i]) contains = false;
                    if (contains) return true;
                } 
            }
            return false;
        }
    }
}
