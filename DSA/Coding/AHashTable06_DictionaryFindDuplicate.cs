using System;
using System.Collections.Generic;

namespace Coding_AHashTable06
{
    class AHashTable06_DictionaryFindDuplicate
    {
        static void Main06()
        {
            List<int> list = new List<int>();
            list.Add(5);
            AggregateByKey_hashmap(list);
        }
        /*
        * Template for using hash map to find duplicates.
        * Replace ReturnType with the actual type of your return value.
        */
        static bool AggregateByKey_hashmap(List<int> keys)
        {
            // Replace Type and InfoType with actual type of your key and value
            Dictionary<int, int> hashmap = new Dictionary<int, int>();
            hashmap.Add(5, 15);
            foreach (int key in keys)
            {
                if (hashmap.ContainsKey(key))
                {
                    if (hashmap.ContainsKey(key))
                    {
                        return true;
                    }
                }
                // Value can be any information you needed (e.g. index)
                hashmap.Add(key, 15);
            }
            return false;
        }
    }
}
