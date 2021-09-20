using System;
using System.Collections.Generic;

class Q0217
{
    static void Main217()
    {
        bool result = ContainsDuplicate(new int[] { 1, 2, 3, 1 });
    }
    static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> hashSet = new HashSet<int>();
        foreach(int n in nums)
            if (!hashSet.Contains(n)) hashSet.Add(n);
            else return true;
        return false;
    }
}