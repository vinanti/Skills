using System;
using System.Collections.Generic;

namespace Coding
{
    class AHashTable04_HashSetFindDuplicate
    {
        static void Main04()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(1);
            Console.WriteLine(FindDuplicates(list));
        }
        /*
        * Template for using hash set to find duplicates.
        */
        static bool FindDuplicates(List<int> keys)
        {
            // Replace Type with actual type of your key
            HashSet<int> hashset = new HashSet<int>();
            foreach (int key in keys)
            {
                if (hashset.Contains(key))
                {
                    return true;
                }
                hashset.Add(key);
            }
            return false;
        }
    }
}
